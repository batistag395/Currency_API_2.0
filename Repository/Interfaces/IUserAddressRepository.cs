using CurrencyAPI.Model;

namespace CurrencyAPI.Repository.Interfaces
{
    public interface IUserAddressRepository
    {
        Task<IResult> UserAddressByCep(int id, string cep, string numResidencial, string complemento);
        List<UserAddress> GetAddressByUser(int id);
    }
}
