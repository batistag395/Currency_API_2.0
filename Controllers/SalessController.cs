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
        public SalessController() : base(new SalesRepository())
        {
        } 
    }
}
