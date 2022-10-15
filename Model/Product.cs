using System.ComponentModel.DataAnnotations;

namespace CurrencyAPI.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int IdCurrency { get; set; }

        public Product()
        {
                
        }
    }
}
