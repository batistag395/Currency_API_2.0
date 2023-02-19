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

        public List<SalesDTO> GetByUser(int id)
        {
            return _conn.Query<SalesDTO>(@"select p.""ProductName"", u.""Name"" as ""UserName"", c.""Name"" as ""PaymentCurrecyName"", 
                                            up.""FinalProductPrice"" as ""FinalPrice"", up.""Date"" as ""SaleDate"" from ""UserProduct"" as up
                                            join ""User"" as u
                                            on u.""Id"" = up.""IdUser""
                                            join ""Product"" as p
                                            on p.""Id"" = up.""IdProduct""
                                            join ""Currency"" as c
                                            on c.""Id"" = up.""IdPaymentCurrency"" where up.""IdUser"" = @IdUser ", new { IdUser = id }).ToList();
        }
    }
}