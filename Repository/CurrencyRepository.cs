using CurrencyAPI.Model;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private IDbConnection _conn;
        public CurrencyRepository()
        {
<<<<<<< HEAD
            _conn = new NpgsqlConnection(@"Server=Container_Docker;User ID=postgres;Password=postgrespw;
                                         Host=host.docker.internal;Port=49153;Database=postgres;");
=======
            _conn = new NpgsqlConnection(@"Server=Docker;User ID=postgres;Password=postgrespw;
                                         Host=host.docker.internal;Port=49153;Database=CurrencyDB;");
>>>>>>> ba9bf7d76111fd3b72f120e1d441c73d0556af99
        }
        public List<Currency> Get()
        {
            return _conn.Query<Currency>(@"SELECT * FROM ""Currency"" ").ToList();
        }
        public Currency GetById(int _id)
        {
<<<<<<< HEAD
            return _conn.QuerySingleOrDefault<Currency>(@"SELECT * FROM ""Currency"" WHERE ""Id"" = @id ", new { Id = _id });
        }
        public void Insert(Currency _currency)
        {
            var sql = _conn.Query(@"INSERT INTO ""Currency""(""Name"", ""Rate"") VALUES(@Name, @Rate", _currency );
=======
            return _conn.QuerySingleOrDefault<Currency>(@"SELECT * FROM ""Currency"" WHERE ""Id"" = @id ", new { Id = id });
        }
        public void Insert(Currency _currency)
        {
            string sql = @"INSERT INTO ""Currency""(""Name"", ""Rate"") VALUES(@Name, @Rate)";
            _conn.Query(sql, _currency);
>>>>>>> ba9bf7d76111fd3b72f120e1d441c73d0556af99
        }
        public double CalcCurrency(string _fromCurrency, string _toCurrency, double _rate)
        {
<<<<<<< HEAD
            double sql = _conn.QuerySingleOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency"" 
                                                            WHERE ""Name"" = @name ", new { Name = _fromCurrency });
            double sql2 = _conn.QuerySingleOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency"" 
                                                             WHERE ""Name"" = @name ", new { Name = _toCurrency });
            return _rate * (sql / sql2);
        }
        public void Update(Currency _currency)
        {    
            if(String.IsNullOrEmpty(_currency.Name))
            {
                _conn.Execute(@"UPDATE ""Currency"" SET ""Rate"" = @Rate 
                              WHERE ""Id"" = @Id ", _currency);
            }
            else if(_currency.Rate == null)
            {
                _conn.Execute(@"UPDATE ""Currency"" SET ""Name"" = @Name 
                              WHERE ""Id"" = @Id ", _currency);
            }
            else
            {
                _conn.Execute(@"UPDATE ""Currency"" SET ""Name"" = @Name, ""Rate"" = @Rate  
                              WHERE ""Id"" = @Id ", _currency);
            }
        }
        public void Delete(int _id)
        {
            _conn.Execute(@"DELETE FROM ""Currency"" WHERE ""Id"" = @id", new { ID = _id });
=======
            double sql = _conn.QuerySingleOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency"" WHERE ""Name"" = @name ",
                                                            new { Name = name });
            double sql2 = _conn.QuerySingleOrDefault<double>(@"SELECT ""Rate"" FROM ""Currency"" WHERE ""Name"" = @name ",
                                                             new { Name = name2 });
            return rate * (sql / sql2);
        }
        public void Update(Currency _currency)
        {
            if (_currency.Name == null)
            {
                var sql = _conn.Execute(@"UPDATE ""Currency"" SET ""Rate"" = @rate 
                                        WHERE ""Id"" = @Id",  _currency);

            }
            else if (_currency.Rate == null)
            {
                var sql = _conn.Execute(@"UPDATE ""Currency"" SET  ""Name"" = @name 
                                        WHERE ""Id"" = @Id",  _currency);

            }
            else
            {
                var sql = _conn.Execute(@"UPDATE ""Currency"" SET  ""Name"" = @name, ""Rate"" = @rate 
                                        WHERE ""Id"" = @Id",  _currency);
            }
        }
        public void Delete(int id)
        {
            _conn.Execute(@"DELETE FROM ""Currency"" WHERE ""Id"" = @id", new { ID = id });
>>>>>>> ba9bf7d76111fd3b72f120e1d441c73d0556af99
        }
    }
}