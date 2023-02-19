using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface ISaleRepository
    {
        public List<SalesDTO> GetAll(); 
        public SalesDTO GetById(object id);
        public List<SalesDTO> GetByUser(int id);
    }
}
