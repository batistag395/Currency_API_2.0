using CurrencyAPI.Model;

namespace CurrencyAPI.Repository.Interfaces
{
    interface ICurrencyRepository : IBaseRepository<Currency>
    {
        double CalcCurrency(string _fromCurrency, string _toCurrency, string date, decimal _rate);
    }
}
