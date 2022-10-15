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
            return _conn.Query<ProductDTO>(@"SELECT * FROM ""Product"" ").ToList();
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
                                                                            ON c.""Id"" != p.""IdCurrency""
                                                                            RIGHT JOIN ""DailyRate"" AS dr2
                                                                            ON c.""Id"" = dr2.""IdCurrency""
                                                                            WHERE dr.""IdCurrency"" = p.""IdCurrency"" and dr.""Name"" = @Date and 
                                                                            dr2.""Name"" =  @Date and  p.""ProductName"" = @ProductName and c.""Name"" = @FinalCurrency",
                                                                            new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency });

            finalPrice = $"Conversão realizada com sucesso, Valor final = {toCurrency} {finalProductsPrice.ToString("F2")}";


            return finalPrice;
        }
        public string toBuyProduct(string productName, string toCurrency, string dailyRate, int id)
        {
            int getProductId = _conn.QuerySingleOrDefault<int>(@"SELECT ""Id"" FROM ""Product""
                                                                WHERE ""ProductName"" = @ProductName ",
                                                                new { ProductName = productName });

            int getPaymentCurrencyId = _conn.QuerySingleOrDefault<int>(@"SELECT ""Id"" FROM ""Currency""
                                                                        WHERE ""Name"" = @Name ",
                                                                        new { Name = toCurrency });

            double finalProductsPriceBought = _conn.QuerySingleOrDefault<double>(@"SELECT (p.""Price"" * dr.""DailyRate"" / dr2.""DailyRate"" ) FROM ""Product"" AS p
                                                                                JOIN ""DailyRate"" AS dr
                                                                                ON p.""IdCurrency"" = dr.""IdCurrency""
                                                                                RIGHT JOIN ""Currency"" AS c
                                                                                ON c.""Id"" != p.""IdCurrency""
                                                                                RIGHT JOIN ""DailyRate"" AS dr2
                                                                                ON c.""Id"" = dr2.""IdCurrency""
                                                                                WHERE dr.""IdCurrency"" = p.""IdCurrency"" and dr.""Name"" = @Date and 
                                                                                dr2.""Name"" =  @Date and  p.""ProductName"" = @ProductName and c.""Name"" = @FinalCurrency",
                                                                                new { ProductName = productName, Date = dailyRate, FinalCurrency = toCurrency });

            var sqlInsert = _conn.Execute(@"insert into ""UserProduct"" (""IdUser"", ""IdProduct"", ""IdPaymentCurrency"", ""FinalProductPrice"", ""Date"")
                                            values(@User, @Product, @PaymentCurrency, @FinalPrice, @Date)",
                                            new { User = id, Product = getProductId, PaymentCurrency = getPaymentCurrencyId, FinalPrice = finalProductsPriceBought, 
                                            Date = DateTime.Now });

            string finalPrice = $"Compra realizada com sucesso, Valor final = {toCurrency} {finalProductsPriceBought.ToString("F2")}";

            return finalPrice;
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
