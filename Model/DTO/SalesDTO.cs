namespace CurrencyAPI.Model.DTO
{
    public class SalesDTO
    {
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public string PaymentCurrecyName { get; set; }
        public double FinalPrice { get; set; }
        public DateTime SaleDate { get; set; }
            
        public SalesDTO()
        {

        }
    }
}
