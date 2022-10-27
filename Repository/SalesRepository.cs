using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class SalesRepository : BaseRepository, ISaleRepository
    {
        public SalesRepository() : base()
        {

        }
        public List<SalesDTO> get()
        {
           return _conn.Query<SalesDTO>(@"select * from ""Get""(); ").ToList();

        }

        public List<SalesDTO> getById(int id)
        {
            return _conn.Query<SalesDTO>(@"select * from ""GetById""(@IdSale);",
                                        new { IdSale = id }).ToList() ;
        }
    }
}