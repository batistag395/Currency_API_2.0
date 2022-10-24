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
            return _conn.Query<ProductDTO>(@"select p.""Id"", p.""ProductName"", p.""Price"" as ""ProductPrice"", c.""Name"" as ""CurrencyName"" from ""Product"" as p
                                            join ""Currency"" as c
                                            on c.""Id"" = p.""IdCurrency"" ").ToList();
        }
        public List<ProductDTO> GetById(int id)
        {
            return _conn.Query<ProductDTO>(@"select p.""Id"", p.""ProductName"", p.""Price"" as ""ProductPrice"", c.""Name"" as ""CurrencyName"" from ""Product"" as p
                                            join ""Currency"" as c
                                            on c.""Id"" = p.""IdCurrency""
                                            where p.""Id"" = @Id ",
                                            new {Id = id}).ToList();
        }
        public string ConvertProductPrice(string productName, string toCurrency, string dailyRate)
        {
            string finalPrice = string.Empty;


            double finalProductsPrice = _conn.QuerySingleOrDefault<double>(@"SELECT (p.""Price"" * dr.""DailyRate"" / dr2.""DailyRate"" ) FROM ""Product"" AS p
                                                                            JOIN ""DailyRate"" AS dr
                                                                            ON p.""IdCurrency"" = dr.""IdCurrency""
                                                                            RIGHT JOIN ""Currency"" AS c
                                                                            ON dr.""IdCurrency"" is not null
                                                                            RIGHT JOIN ""DailyRate"" AS dr2
                                                                            ON c.""Id"" = dr2.""IdCurrency""
                                                                            WHERE dr.""IdCurrency"" = p.""IdCurrency"" and dr.""Name"" = @Date and 
                                                                            dr2.""Name"" =  @Date and  p.""ProductName"" = @ProductName and c.""Name"" = @FinalCurrency",
                                                                            new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency });

            finalPrice = $"Conversão realizada com sucesso, Valor final = {toCurrency} {Math.Round(finalProductsPrice, 2)}";


            return finalPrice;
        }
        public void toBuyProduct(string productName, string toCurrency, string dailyRate, int id)
        {
            toCurrency = toCurrency.ToUpper();

            double finalProductsPriceBought = _conn.Execute(@"INSERT INTO ""UserProduct"" (""IdUser"", ""IdProduct"", ""IdPaymentCurrency"", ""FinalProductPrice"", ""Date"")
                                                            SELECT u.""Id"", p.""Id"", c.""Id"",  (p.""Price"" * dr.""DailyRate"" / dr2.""DailyRate"" ), @DailyDate FROM ""Product"" AS p
                                                            join ""User"" as u on u.""Id"" = @UserId  
                                                            JOIN ""DailyRate"" AS dr
                                                            ON p.""IdCurrency"" = dr.""IdCurrency""
                                                            RIGHT JOIN ""Currency"" AS c
                                                            ON dr.""IdCurrency"" is not null
                                                            RIGHT JOIN ""DailyRate"" AS dr2
                                                            ON c.""Id"" = dr2.""IdCurrency""
                                                            WHERE dr.""IdCurrency"" = p.""IdCurrency"" and dr.""Name"" = @Date and 
                                                            dr2.""Name"" =  @Date and  p.""ProductName"" = @ProductName and c.""Name"" = @FinalCurrency",
                                                            new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency, UserId = id, DailyDate = DateTime.Now });

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
