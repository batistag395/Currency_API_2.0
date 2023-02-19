using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressesController : BaseController<UserAddress>
    {
        IConfiguration _configuration;
        IUserAddressRepository _userAddressRepository;
        IFindAddressByCepRepository _findAddressByCepRepository;
        public UserAddressesController(IFindAddressByCepRepository findAddressByCepRepository, IConfiguration configuration, IUserAddressRepository userAddressRepository1) : base(new UserAddressRepository(findAddressByCepRepository, configuration))
        {
            _configuration = configuration;
            _userAddressRepository = userAddressRepository1;
            _findAddressByCepRepository = findAddressByCepRepository;
        }
        [HttpPost("InsertUserAddress")]
        public async Task<IResult> UserAddress(int id, string cep, string numResidencial, string complemento)
        {
            await _userAddressRepository.UserAddressByCep(id, cep, numResidencial, complemento);
            return Results.Ok();
        }
        [HttpPost("GetAddressByUser")]
        public IResult GetAddressByUser(int id)
        {
            return Results.Ok(_userAddressRepository.GetAddressByUser(id));
        }
    }
}
