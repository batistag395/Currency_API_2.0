using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository() : base()
        {

        }
    }
}
