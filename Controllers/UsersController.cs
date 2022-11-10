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
        IConfiguration _configuration;
        public UsersController(IConfiguration configuration) : base(new UserRepository(configuration))
        {
            _configuration = configuration;
        }
    }
}
