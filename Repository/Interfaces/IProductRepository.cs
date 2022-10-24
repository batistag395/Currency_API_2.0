using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    interface IProductRepository
    {
        public List<ProductDTO> GetById(int id);
        public List<ProductDTO> Get();
        public string ConvertProductPrice(string _productName, string _toCurrency, string dailyCurrency);
        public void toBuyProduct(string _productName, string _toCurrency, string dailyCurrency, int id);
        public void Insert(Product _product);
        public void Update(Product _product);
        public void Delete(string _name);
    }
}