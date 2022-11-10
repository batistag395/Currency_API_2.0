using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CurrencyAPI.Repository
{
    public class SendEmailRepository : BaseRepository<EmailMessage>, ISendEmailRepository
    {

        IConfiguration _configuration;
        IConvertDataRepository _convertDataRepository;
        public SendEmailRepository(IConfiguration configuration) : base(configuration)
        {
            _convertDataRepository = new ConvertDataRepository(configuration);
            _configuration = configuration;
        }           
        public List<EmailMessageDTO> SendMessage(string productName, int id)
        {
            var message = _conn.Query<EmailMessageDTO>(@"select * from ""SendEmailSuccesfullyBought""(@UserId, @ProductName);", 
                                                        new {UserId = id, ProductName = productName}).ToList();
            return message;
        }
        public void SendEmail(string productName, int id)
        {
            var conn = _convertDataRepository.decryptData(_configuration.GetConnectionString("conn"));

            var email = _convertDataRepository.decryptData(_configuration.GetValue<string>("EmailData:Email"));

            var password = _convertDataRepository.decryptData(_configuration.GetValue<string>("EmailData:PassWord")) ;

            var userEmail = _conn.QuerySingleOrDefault<string>(@"select ""Email"" from ""User"" where ""Id"" = @Id ", new { Id = id });
            
            MailMessage mailMessage = new($"{email}", $"`{userEmail}");

            mailMessage.Subject = $"Compra realizada com sucesso!";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = $"<p> {_conn.QuerySingleOrDefault(@"select ""Body"" from ""EmailMessage"" ")} </p>";
            mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential($"{email}", $"{password}");
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);

            Console.WriteLine("Seu email foi enviado com sucesso! :)");
            Console.ReadLine();
          
        }

    }
}