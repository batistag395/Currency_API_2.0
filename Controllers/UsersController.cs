using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository userRepository;
        public UsersController()
        {
            userRepository = new UserRepository();
        }
        [HttpGet("Get")]
        public IResult Get()
        {
            return Results.Ok(userRepository.Get());
        }
        [HttpGet("{id}")]
        public IResult GetById(int id)
        {
            return Results.Ok(userRepository.GetById(id));
        }
        [HttpPost("Insert")]
        public IResult insert(User user)
        {
            userRepository.insert(user);
            return Results.Ok();
        }
        [HttpPut("Update")]
        public IResult update(User user)
        {
            userRepository.Update(user);
            return Results.Ok();
        }
        [HttpDelete("{id}")]
        public IResult delete(int id)
        {
            userRepository.Delete(id);
            return Results.Ok();
        }
    }
}
