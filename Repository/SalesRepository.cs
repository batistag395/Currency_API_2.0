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
           return _conn.Query<SalesDTO>(@"select p.""ProductName"", u.""Name"" as ""UserName"", c.""Name"" as ""PaymentCurrecyName"", 
                                        up.""FinalProductPrice"" as ""FinalPrice"", up.""Date"" as ""SaleDate"" from ""UserProduct"" as up
                                            join ""User"" as u
                                            on u.""Id"" = up.""IdUser""
                                            join ""Product"" as p
                                            on p.""Id"" = up.""IdProduct""
                                            join ""Currency"" as c
                                            on c.""Id"" = up.""IdPaymentCurrency"" ").ToList();

        }

        public List<SalesDTO> getById(int id)
        {
            return _conn.Query<SalesDTO>(@"select p.""ProductName"", u.""Name"" as ""UserName"", c.""Name"" as ""PaymentCurrecyName"", 
                                                            up.""FinalProductPrice"" as ""FinalPrice"", up.""Date""as ""SaleDate"" from ""UserProduct"" as up
                                                            join ""User"" as u
                                                            on u.""Id"" = up.""IdUser""
                                                            join ""Product"" as p
                                                            on p.""Id"" = up.""IdProduct""
                                                            join ""Currency"" as c
                                                            on c.""Id"" = up.""IdPaymentCurrency"" 
                                                             where up.""Id"" = @IdSale ",
                                                            new { IdSale = id }).ToList() ;
        }
    }
}