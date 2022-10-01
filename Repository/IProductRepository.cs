using CurrencyAPI.Model;

namespace CurrencyAPI.Repository
{
    interface IProductRepository
    {
        //public Product GetById(int id);
        public List<Product> Get();
        public double ConvertProductPrice(string _productName, string _toCurrency);
        public void Insert(Product _product);
        public void Update(Product _product);
        public void Delete(string _name);
    }
}
