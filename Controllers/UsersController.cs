using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User>
    {
        IUserRepository userRepository;
        public UsersController() : base(new UserRepository())
        {
            userRepository = new UserRepository();
        }
    }
}
