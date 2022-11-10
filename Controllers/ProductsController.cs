using CurrencyAPI.Model;
using CurrencyAPI.Model.DTO;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<ProductDTO>
    {
        ISendEmailRepository _sendEmailRepository;
        IProductRepository _productRepository;
        public ProductsController(IConfiguration configuration) : base(new ProductRepository(configuration))
        {
            _sendEmailRepository = new SendEmailRepository(configuration);
            _productRepository = new ProductRepository(configuration);
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
    }
}
