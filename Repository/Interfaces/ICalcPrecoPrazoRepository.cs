using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using Refit;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface ICalcPrecoPrazoRepository
    {
        List<CalcPrecoPrazoDTO> CalcPrecoPrazo(string codEmpresa, string senha, string cepOrigem, string cepDestino,
                                                string peso, int codFormato, decimal comprimento,
                                                decimal altura, decimal largura, decimal diametro, string maoPropria,
                                                decimal valorDeclarado, string avisoRecebimento);
        List<CalcPrecoPrazoDTO> paransToCalculate(int idProduct, string cepOrigem, string cepDestino);
    }
}
