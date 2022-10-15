using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    interface ISaleRepository
    {
        public List<SalesDTO> get();
        public List<SalesDTO> getById(int id);
    }
}
