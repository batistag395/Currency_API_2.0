using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface IProductRepository
    {
        public string ConvertProductPrice(string _productName, string _toCurrency, string dailyCurrency);
        public void toBuyProduct(string _productName, string _toCurrency, string dailyCurrency, int id);
    }
}