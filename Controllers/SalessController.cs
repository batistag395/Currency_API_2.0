using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalessController : BaseController<SalesDTO>
    {
        IConfiguration _configuration;
        ISaleRepository _saleRepository;
        public SalessController(IConfiguration configuration, ISaleRepository saleRepository) : base(new SalesRepository(configuration))
        {
            _configuration = configuration;
            _saleRepository = saleRepository;
        }
        [HttpGet("GetSaleByUser")]
        public IResult GetSaleByUser(int id)
        {
            return Results.Ok(_saleRepository.GetByUser(id));
        }
    }
}
