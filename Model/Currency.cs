using System.ComponentModel.DataAnnotations;

namespace CurrencyAPI.Model
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public Currency()
        {

        }
    }
}
