namespace CurrencyAPI.Model
{
    public class UserProduct
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdProduct { get; set; }
        public int IdPaymentCurrency { get; set; }
        public decimal FinalProductPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
