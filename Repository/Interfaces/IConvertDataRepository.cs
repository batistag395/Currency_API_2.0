namespace CurrencyAPI.Repository.Interfaces
{
    public interface IConvertDataRepository
    {
        string encryptData(string data);
        string decryptData(string data);
    }
}