using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Newtonsoft.Json;
using Refit;
using System.Xml;
using System.Xml.Serialization;

namespace CurrencyAPI.Repository
{
    public class CalcPrecoPrazoRepository : BaseRepository<CalcPrecoPrazo>, ICalcPrecoPrazoRepository
    {
        IConfiguration _configuration;
        public CalcPrecoPrazoRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }
        public List<CalcPrecoPrazoDTO> CalcPrecoPrazo(string codEmpresa, string senha, string cepOrigem, string cepDestino, 
                                                        string peso, int codFormato, decimal comprimento,  
                                                        decimal altura, decimal largura, decimal diametro, string maoPropria, 
                                                        decimal valorDeclarado, string avisoRecebimento)
        {
            var listServicos = new List<string>();
            {
                listServicos.Add("Sedex Varejo/40010");
                listServicos.Add("Sedex a Cobrar/40045");
                listServicos.Add("Sedex 10/40215");
                listServicos.Add("Sedex Hoje/40290");
                listServicos.Add("Pac/41106");
            }
            var ws = new CalcPrecoPrazoWS.
                    CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWS.CalcPrecoPrazoWSSoapClient.
                    EndpointConfiguration.CalcPrecoPrazoWSSoap12);

            var listReturno = new List<CalcPrecoPrazoDTO>();
            foreach (var item in listServicos)
            {
                if (codEmpresa == null && senha == null)
                {
                    codEmpresa = string.Empty;
                    senha = string.Empty;
                }
                string[] readLines = item.Split('/');
                var result = ws.CalcPrecoPrazo(codEmpresa, senha, readLines[1], cepOrigem, cepDestino, peso, codFormato, 
                                                comprimento, altura, largura, diametro, maoPropria, valorDeclarado, avisoRecebimento);
                var resposta = result.Servicos.FirstOrDefault();
                listReturno.Add(new CalcPrecoPrazoDTO(readLines[0], resposta.PrazoEntrega, resposta.Valor));
            }
            return listReturno;
        } 
        public List<CalcPrecoPrazoDTO> paransToCalculate(int idProduct, string cepOrigem, string cepDestino)
        {
            List<CalcPrecoPrazo> productData = _conn.Query<CalcPrecoPrazo>(@"select ""peso"", ""formato"", ""comprimento"", 
                                                                            ""altura"", ""largura"",""diametro"", ""maopropria"", ""valordeclarado"", 
                                                                            ""avisoRecebimento""
                                                                            from ""ProductData"" where ""idproduct"" = @IdProduct ",
                                                                            new { IdProduct = idProduct }).ToList();
            
            string codEmpresa = "";
            string senha = "";
            string peso = "";
            int codFormato = 0;
            decimal comprimento = 0;
            decimal altura = 0;
            decimal largura = 0;
            decimal diametro = 0;
            string maoPropria = "";
            decimal valorDeclarado = 0;
            string avisoRecebimento = "";

            foreach (var item in productData)
            {
                peso = item.peso;
                codFormato = item.formato;
                comprimento = item.comprimento;
                altura = item.altura;
                largura = item.largura;
                maoPropria = item.maoPropria;
                valorDeclarado = item.valorDeclarado;
                diametro = item.diametro;
                avisoRecebimento = item.avisoRecebimento;
            }
            var calc = CalcPrecoPrazo(codEmpresa, senha, cepOrigem, cepDestino, peso, codFormato, comprimento,
                                        altura, largura, diametro, maoPropria, valorDeclarado, avisoRecebimento);
            return calc;
        }
    }
}
