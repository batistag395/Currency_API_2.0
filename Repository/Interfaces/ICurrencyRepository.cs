using CurrencyAPI.Model;

namespace CurrencyAPI.Repository.Interfaces
{
    interface ICurrencyRepository
    {
        public List<Currency> Get();
        public Currency GetById(int _id);
        public void Insert(Currency _currency);
        public void Update(Currency _currency);
        public void Delete(int _id);
        public string CalcCurrency(string _fromCurrency, string _toCurrency, string date, double _rate);
    }
}
