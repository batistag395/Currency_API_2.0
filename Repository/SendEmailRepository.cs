using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class SendEmailRepository : BaseRepository, ISendEmailRepository
    {
        public SendEmailRepository() : base()
        {

        }
        public List<EmailMessageDTO> SendEmail(string productName, int id)
        {
            var message = _conn.Query<EmailMessageDTO>(@" select em.""Title"",
                                                    replace(
                                                        replace(
                                                            replace(
                                                                replace(""Body"", '@Name', U.""Name""),
                                                                '@ProductName', p.""ProductName""),
                                                                '@PaymentCurrency', c.""Name""),
                                                                '@FinalProductPrice', cast(up.""FinalProductPrice"" as varchar)) as ""Body""
                                                    from ""EmailMessage"" as em
                                                    join ""User"" as u on u.""Id"" = @UserId
                                                    join ""UserProduct"" as up on up.""IdUser"" = u.""Id""
                                                    join ""Product"" as p on p.""ProductName"" = @ProductName
                                                    join ""Currency"" as c on c.""Id"" = up.""IdPaymentCurrency"" 
                                                    order by up.""Id"" desc limit 1", new {UserId = id, ProductName = productName}).ToList();
            return message;
        }
    }
}