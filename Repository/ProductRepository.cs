using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository() : base()
        {
        }
        public List<ProductDTO> Get()
        {
            return _conn.Query<ProductDTO>(@"select * from ""GetProduct""();").ToList();
        }
        public List<ProductDTO> GetById(int id)
        {
            return _conn.Query<ProductDTO>(@"select * from ""GetProduct""(@Id);",
                                            new {Id = id}).ToList();
        }
        public string ConvertProductPrice(string productName, string toCurrency, string dailyRate)
        {
            string finalPrice = string.Empty;


            double finalProductsPrice = _conn.QuerySingleOrDefault<double>(@"select * from ""ConvertProductPrice""(@ProductName, @Date, @FinalCurrency);",
                                                                            new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency });

            finalPrice = $"Conversão realizada com sucesso, Valor final = {toCurrency} {finalProductsPrice}";


            return finalPrice;
        }
        public void toBuyProduct(string productName, string toCurrency, string dailyRate, int id)
        {
            toCurrency = toCurrency.ToUpper();

            double finalProductsPriceBought = _conn.Execute(@"select ""ToBuyProduct""(@ProductName, @FinalCurrency, @Date,   @UserId)",
                                                            new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency, UserId = id});

        }
        public void Insert(Product product)
        {
            var sql = _conn.Execute(@"INSERT INTO ""Product"" (""ProductName"", ""Price"", ""IdCurrency"") 
                                    VALUES(@ProductName, @price, @idCurrency) ", product);
        }
        public void Update(Product product)
        {
            var sql = _conn.Execute(@"UPDATE ""Product"" 
                                    SET ""Name"" = @name, ""Price"" = @price, ""IdProduct"" = @idProduct ",
                                    product);
        }
        public void Delete(string name)
        {
            _conn.Execute(@"DELETE FROM ""Product""  
                            WHERE ""ProductName"" = @ProductName ", 
                            new { ProductName = name });
        }
    }
}
