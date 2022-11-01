using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class ProductRepository : BaseRepository<ProductDTO>, IProductRepository
    {
        public ProductRepository() : base()
        {
        }
        public override void Insert(ProductDTO product)
        {
            _conn.Execute(@"select ""InsertProduct""(@ProductName, @ProductPrice, @CurrencyName)", product);

        }
        public override List<ProductDTO> GetAll()
        {
            return _conn.Query<ProductDTO>(@"select * from ""GetProduct""();").ToList();
        }
        public override ProductDTO GetById(object id)
        {
            return _conn.QuerySingleOrDefault<ProductDTO>(@"select * from ""GetProduct""(@Id);", new {Id = id});
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
    }
}
