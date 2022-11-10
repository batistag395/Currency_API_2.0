using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class SalesRepository : BaseRepository<SalesDTO>, ISaleRepository
    {
        IConfiguration _configuration;
        public SalesRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
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