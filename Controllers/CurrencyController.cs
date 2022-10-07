using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private ICurrencyRepository _currencyRepository;
        public CurrencyController()
        {
            _currencyRepository = new CurrencyRepository();
        }
        [HttpGet("GetCurrencyList")]
        public IResult GetCurrencyList()
        {
            return Results.Ok(_currencyRepository.Get());
        }
        [HttpGet("{id}")]
        public IResult GetById(int id)
        {
            var findById = _currencyRepository.GetById(id);

            if (findById == null) 
            { 
                return Results.NotFound(); 
            }
            else
            {
                return Results.Ok(findById);
            }
        }
        [HttpPatch("AddNewCurrency")]
        public IResult AddCurrency(Currency _currency)
        {
           _currencyRepository.Insert(_currency);
            return Results.Ok();
        }
        [HttpPost("CalculateCurrecy")]
        public IResult CalcCurrency(string _fromCurremcy, string _toCurrency, double _rate)
        {
            return Results.Ok(_currencyRepository.CalcCurrency(_fromCurremcy, _toCurrency, _rate)); 
        }
        [HttpPut("UpdateCurrency")]
        public IResult Update(Currency _currency)
        {
            _currencyRepository.Update(_currency);
            return Results.Ok();
        }
        [HttpDelete("DeleteCurrency")]
        public IResult Update(int _id)
        {
            _currencyRepository.Delete(_id);
            return Results.Ok();
        }
    }
}
