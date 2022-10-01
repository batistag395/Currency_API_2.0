using System.ComponentModel.DataAnnotations;

namespace CurrencyAPI.Model
{
    public class Product
    {
        [Key]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int IdCurrency { get; set; }

        public Product()
        {
                
        }

        public Product(string productName, double price, int idProduct)
        {
            ProductName = productName;
            Price = price;
            IdCurrency = idProduct;
        }
    }
}
