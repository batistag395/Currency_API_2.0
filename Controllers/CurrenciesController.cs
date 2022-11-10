using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : BaseController<Currency>
    {
        private ICurrencyRepository _currencyRepository;
        IConfiguration _configuration;
        public CurrenciesController(IConfiguration configuration) : base(new CurrencyRepository(configuration))
        {
            _currencyRepository = new CurrencyRepository(configuration);
            _configuration = configuration;
        }
        [HttpPost("CalculateCurrecy")]
        public IResult CalcCurrency(string _fromCurrency, string _toCurrency, string date, decimal _rate)
        {
            return Results.Ok(_currencyRepository.CalcCurrency(_fromCurrency, _toCurrency, date, _rate));
        }
    }
}
