namespace CurrencyAPI.Model.DTO
{
    public class CalcPrecoPrazoDTO
    {
        public string NomeServico { get; set; }
        public string Prazo { get; set; }
        public string Valor { get; set; }

        public CalcPrecoPrazoDTO()
        {

        }

        public CalcPrecoPrazoDTO(string nomeServico, string prazo, string valor)
        {
            NomeServico = nomeServico;
            Prazo = prazo;
            Valor = valor;
        }
    }
}
