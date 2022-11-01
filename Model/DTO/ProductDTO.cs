namespace CurrencyAPI.Model.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string CurrencyName { get; set; }

        public ProductDTO()
        {
                
        }
    }
}
