using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalessController : ControllerBase
    {
        private ISaleRepository _salesRepository;
        public SalessController()
        {
            _salesRepository = new SalesRepository();
        }

        [HttpGet("GetAll")]
        public IResult get()
        {
            return Results.Ok(_salesRepository.get());
        }
        [HttpGet("GetById")]
        public IResult getById(int id)
        {
            return Results.Ok(_salesRepository.getById(id));
        }  
    }
}
