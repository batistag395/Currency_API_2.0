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
            var sql = _conn.Query(@"INSERT INTO ""Currency""(""Name"", ""Rate"") VALUES(@Name, @Rate", _currency );
        }
       
        public string CalcCurrency(string _fromCurrency, string _toCurrency, string date, double _rate)
        {
            double convertCurrency = _conn.QuerySingleOrDefault<double>(@"SELECT (@Rate * dr2.""DailyRate"" / dr.""DailyRate"") FROM ""DailyRate"" AS dr
                                                                        JOIN ""Currency"" AS c
                                                                        ON c.""Id"" = dr.""IdCurrency""

                                                                        JOIN ""Currency"" AS c2
                                                                        ON c2.""Id"" != c.""Id""

                                                                        JOIN ""DailyRate"" AS dr2
                                                                        ON c2.""Id"" = dr2.""IdCurrency""

                                                                        WHERE c.""Name"" = @NameCurrency AND dr.""Name"" = @Date AND 
                                                                        c2.""Name"" = @NameFinalCurrency AND dr2.""Name"" = @Date",
                                                                        new { NameCurrency = _fromCurrency, NameFinalCurrency = _toCurrency, @Date = date, Rate = _rate });
            return convertCurrency.ToString("F2");
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
        }
    }
}