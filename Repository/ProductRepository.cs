using CurrencyAPI.Model;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private IDbConnection _conn;
        public ProductRepository()
        {
            _conn = new NpgsqlConnection(@"Server=Container_Docker;User ID=postgres;Password=postgrespw;
                                          Host=host.docker.internal;Port=49153;Database=postgres;");
        }
        public List<Product> Get()
        {
            return _conn.Query<Product>(@"SELECT * FROM ""Product"" ").ToList();
        }
        //public Product GetById(int id)
        //{
        //    var sql = _conn.QuerySingleOrDefault<Product>(@"SELECT * FROM ""Product"" ");
        //    return sql;
        //}
        public double ConvertProductPrice(string productName, string toCurrency, string dailyRate)
         {
            int getDate = _conn.QuerySingleOrDefault<int>(@"SELECT ""Id"" FROM ""Date"" 
                                                            WHERE ""Name"" = @Name ", 
                                                            new { Name = dailyRate });

            int idCurrency = _conn.QuerySingleOrDefault<int>(@"SELECT ""IdCurrency"" FROM ""Product"" 
                                                             WHERE ""ProductName"" = @ProductName ",
                                                             new { ProductName = productName });

            double getDailyValue = _conn.QuerySingleOrDefault<double>(@"SELECT ""DailyRate"" FROM ""DateRate""
                                                                      WHERE ""IdDate"" = @IdDate AND ""IdCurrency"" = @IdCurrency ",
                                                                      new {IdDate = getDate, IdCurrency = idCurrency});

            var updateRate = _conn.Execute(@"UPDATE ""Currency"" SET ""Rate"" =@Rate 
                                           WHERE ""Id"" = @Id ",
                                           new {Rate = getDailyValue, Id = idCurrency});

            double getCurrencyProductValue = _conn.QuerySingleOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency"" 
                                                                                WHERE ""Name"" = @Name ",
                                                                                new { Name = toCurrency });

            double getProductPrice = _conn.QuerySingleOrDefault<double>(@"SELECT ""Price"" FROM ""Product""
                                                                        WHERE ""ProductName"" = @ProductName ",
                                                                        new { ProductName = productName });

            double sql = _conn.QueryFirstOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency""
                                                           JOIN ""Product"" ON ""Id"" = @Id ",
                                                           new { Id = idCurrency });

            return getProductPrice * (sql / getCurrencyProductValue);
        }
        public void Insert(Product product)
        {
            var sql = _conn.Execute(@"INSERT INTO ""Product"" (""ProductName"", ""Price"", ""IdCurrency"") 
                                    VALUES(@ProductName, @price, @idCurrency) ", product) ;
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
                            WHERE ""ProductName"" = @ProductName ", new { ProductName = name });
        }
    }
}
