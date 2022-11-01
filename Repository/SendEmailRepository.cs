using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class SendEmailRepository : BaseRepository<EmailMessage>, ISendEmailRepository
    {
        public SendEmailRepository() : base()
        {

        }
        public List<EmailMessageDTO> SendEmail(string productName, int id)
        {
            var message = _conn.Query<EmailMessageDTO>(@"select * from ""SendEmailSuccesfullyBought""(@UserId, @ProductName);", 
                                                        new {UserId = id, ProductName = productName}).ToList();
            return message;
        }
    }
}