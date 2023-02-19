using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<ProductDTO>
    {
        IConfiguration _configuration;
        ISendEmailRepository _sendEmailRepository;
        IProductRepository _productRepository;
        IFindAddressByCepRepository _findAddressByCepRepository;
        ICalcPrecoPrazoRepository _calcPrecoPrazoRepository;
        public ProductsController(ICalcPrecoPrazoRepository calcPrecoPrazoRepository, IFindAddressByCepRepository findAddressByCepRepository, IConfiguration configuration) : base(new ProductRepository(configuration))
        {
            _calcPrecoPrazoRepository = calcPrecoPrazoRepository;
            _configuration = configuration;
            _sendEmailRepository = new SendEmailRepository(configuration);
            _productRepository = new ProductRepository(configuration);
            _findAddressByCepRepository = findAddressByCepRepository;
        }

        [HttpPost("ConvertProductPrice")]
        public IResult ConvertPrice(string _productName, string _toCurrency, string dailyCurrency)
        {
            return Results.Ok(_productRepository.ConvertProductPrice(_productName, _toCurrency, dailyCurrency));
        }
        [HttpPost("toBuyProduct")]
        public IResult toBuyProduct(string _productName, string _toCurrency, string dailyCurrency, int id)
        {
            _productRepository.toBuyProduct(_productName, _toCurrency, dailyCurrency, id);
            _sendEmailRepository.SendEmail(_productName, id);
            return Results.Ok();
            //return Results.Ok(_sendEmailRepository.SendMessage(_productName, id));
        }
        [HttpGet("GetAddressByCep")]
        public async Task<IResult> findAddressByCep(string cep)
        {
            var userAddress = new List<Task<FindAddressByCep>>();
            userAddress.Add(_findAddressByCepRepository.findAddressByCep(cep));

            var response = await _findAddressByCepRepository.findAddressByCep(cep);
            return Results.Ok(response);
        }
        [HttpGet("CalcPrecoPrazo")]
        public IResult CalcPrecoPrazo(int idProduct, string cepOrigem, string cepDestino)
        {
            return Results.Ok(_calcPrecoPrazoRepository.paransToCalculate(idProduct, cepOrigem, cepDestino));
        }
    }
}