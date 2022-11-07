using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface ISendEmailRepository
    {
        List<EmailMessageDTO> SendMessage(string productName, int id);
        void SendEmail(string productName, int id);
    }
}
