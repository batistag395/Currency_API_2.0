using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Newtonsoft.Json;
using Refit;
using System.Text.Json;

namespace CurrencyAPI.Repository
{
    public class FindAddressByCepRepository : IFindAddressByCepRepository
    {
        public FindAddressByCepRepository()
        {
        }
        public async Task<FindAddressByCep> findAddressByCep(string cep)
        {
            //var meuCep = RestService.For<IFindAddressByCepRepository>("https://viacep.com.br/");
            //var result = await meuCep.findAddressByCep(cep);
            //return result;

            HttpClient httpClient = new HttpClient();
            var request = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json");
            var response = await request.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<FindAddressByCep>(response);
            return json;
        }
    }
}
