using CurrencyAPI.Model;
using CurrencyAPI.Repository.Interfaces;
using Dapper;

namespace CurrencyAPI.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        IConfiguration _configuration;
        public UserRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }
    }
}
