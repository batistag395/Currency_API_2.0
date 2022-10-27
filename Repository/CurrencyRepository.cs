using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Npgsql;
using System.Data;

namespace CurrencyAPI.Repository
{
    public class CurrencyRepository : BaseRepository, ICurrencyRepository
    {
        public CurrencyRepository() : base()
        {
        }
        public List<Currency> Get()
        {
            return _conn.Query<Currency>(@"SELECT * FROM ""Currency"" ").ToList();
        }

        public Currency GetById(int _id)
        {
            return _conn.QuerySingleOrDefault<Currency>(@"SELECT * FROM ""Currency"" WHERE ""Id"" = @id ", new { Id = _id });
        }
        public void Insert(Currency _currency)
        {
            var sql = _conn.Query(@"INSERT INTO ""Currency""(""Name"") VALUES(@Name, @Rate", _currency);
        }

        public double CalcCurrency(string _fromCurrency, string _toCurrency, string _date, decimal _rate)
        {
           return _conn.QuerySingleOrDefault<double>(@"select * from ""ConvertCurrency""(@initial_currency, @final_currency, @daily_rate, @rate)",
                                                     new { initial_currency = _fromCurrency, final_currency = _toCurrency, daily_rate = _date, rate = _rate });

        }
        public void Update(Currency _currency)
        {

            _conn.Execute(@"UPDATE ""Currency"" SET ""Name"" = @Name  
                              WHERE ""Id"" = @Id ", _currency);

        }
        public void Delete(int _id)
        {
            _conn.Execute(@"DELETE FROM ""Currency"" WHERE ""Id"" = @id", new { ID = _id });
        }
    }
}