using CurrencyAPI.Repository.Interfaces;
using System.Text;

namespace CurrencyAPI.Repository
{
    public class ConvertDataRepository : IConvertDataRepository
    {
        IConfiguration _configuration;
        public ConvertDataRepository(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        public string encryptData(string data)
        {
            byte[] dataToBase64 = Encoding.ASCII.GetBytes(data);
            return Convert.ToBase64String(dataToBase64);
        } 
        public string decryptData(string data)
        {
            byte[] dataToBase64 = Convert.FromBase64String(data);
            return System.Text.ASCIIEncoding.ASCII.GetString(dataToBase64);
        }
    }
}
