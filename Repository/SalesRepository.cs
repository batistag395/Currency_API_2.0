using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class SalesRepository : BaseRepository<SalesDTO>, ISaleRepository
    {
        public SalesRepository() : base()
        {

        }
        public override List<SalesDTO> GetAll()
        {
           return _conn.Query<SalesDTO>(@"select * from ""Get""(); ").ToList();

        }

        public override SalesDTO GetById(object id)
        {
            return _conn.QuerySingleOrDefault<SalesDTO>(@"select * from ""GetById""(@IdSale);",
                                        new { IdSale = id });
        }
    }
}