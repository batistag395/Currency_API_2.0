using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
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
            var meuCep = RestService.For<IFindAddressByCepRepository>("https://viacep.com.br/");
            var result = await meuCep.findAddressByCep(cep);
            return result;
        }
    }
}
