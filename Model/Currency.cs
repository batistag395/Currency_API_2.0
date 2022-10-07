using System.ComponentModel.DataAnnotations;

namespace CurrencyAPI.Model
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Rate { get; set; }

        public Currency()
        {

        }

        public Currency(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Currency(int id, double rate)
        {
            Id = id;
            Rate = rate;
        }

        public Currency(int id, string name, double rate)
        {
            Id = id;
            Name = name;
            Rate = rate;
        }
    }
}
