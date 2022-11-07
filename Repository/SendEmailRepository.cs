using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository.Interfaces;
using Dapper;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CurrencyAPI.Repository
{
    public class SendEmailRepository : BaseRepository<EmailMessage>, ISendEmailRepository
    {

        readonly IConfiguration _configuration;
        public SendEmailRepository(IConfiguration configuration) : base()
        {
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
            string email = _configuration.GetSection("EnailDate").GetSection("Email").Value;
            string password = _configuration.GetSection("EnailDate").GetSection("PassWord").Value;

            string userEmail = _conn.QuerySingleOrDefault<string>(@"select ""Email"" from ""User"" where ""Id"" = @Id ", new { Id = id });
            MailMessage mailMessage = new($"{email}", $"`{userEmail}");

            mailMessage.Subject = $"Compra realizada com sucesso!";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = $"<p> {_conn.QuerySingleOrDefault(@"select ""Body"" from ""EmailMessage"" ")} </p>";
            mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential($"{email}", $"{password}");

            smtpClient.EnableSsl = true;

            smtpClient.Send(mailMessage);

            Console.WriteLine("Seu email foi enviado com sucesso! :)");
            Console.ReadLine();
          
        }
    }
}