using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    interface ISaleRepository
    {
        public List<SalesDTO> GetAll(); 
        public SalesDTO GetById(object id);
    }
}
