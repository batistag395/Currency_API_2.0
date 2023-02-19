using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using Refit;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface IFindAddressByCepRepository
    {
        //[Get("/ws/{cep}/json")]
        Task<FindAddressByCep> findAddressByCep(string cep);
    }
}
