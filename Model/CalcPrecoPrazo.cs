using System.Xml.Serialization;

namespace CurrencyAPI.Model
{
    public class CalcPrecoPrazo
    {
        public string peso { get; set; }
        public int formato { get; set; }
        public decimal comprimento { get; set; }
        public decimal altura { get; set; }
        public decimal largura { get; set; }
        public string maoPropria { get; set; }
        public decimal valorDeclarado { get; set; }
        public string avisoRecebimento { get; set; }
        public decimal diametro { get; set; }

        public CalcPrecoPrazo()
        {
        }
    }
}
