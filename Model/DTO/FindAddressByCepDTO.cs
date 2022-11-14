namespace CurrencyAPI.Model.DTO
{
    public class FindAddressByCepDTO
    {
        public string? Cep { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Regiao { get; set; }
        public string? Rua { get; set; }
        public FindAddressByCepDTO()
        {
        }
    }
}
