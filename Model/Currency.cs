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
<<<<<<< HEAD
=======

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

>>>>>>> ba9bf7d76111fd3b72f120e1d441c73d0556af99
        public Currency(int id, string name, double rate)
        {
            Id = id;
            Name = name;
            Rate = rate;
        }
    }
}
