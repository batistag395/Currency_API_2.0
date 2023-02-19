using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User>
    {
        IConfiguration _configuration;
        IUserRepository _userRepository;
        public UsersController(IConfiguration configuration, IUserRepository userRepository) : base(new UserRepository(configuration))
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }        
    }
}
