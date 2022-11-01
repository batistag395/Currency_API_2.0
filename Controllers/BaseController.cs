using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        private IBaseRepository<T> _baseRepository;

        public BaseController(IBaseRepository<T> baseRepository) 
        {
            _baseRepository = baseRepository;
        }
        [HttpGet("GetAll")]
        public virtual IResult GetAll()
        {
            return Results.Ok(_baseRepository.GetAll());
        }
        [HttpGet("Get{id}")]
        public virtual IResult GetBYId(int id)
        {
            var findById = _baseRepository.GetById(id);

            if (findById == null)
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(findById);
            }
        }
        [HttpPost("Insert")]
        public virtual IResult Insert(T model)
        {
            _baseRepository.Insert(model);
            return Results.Ok();
        }
        [HttpPut("Update")]
        public virtual IResult Update(T model)
        {
            _baseRepository.Update(model);
            return Results.Ok();
        }
        [HttpDelete("Delete")]
        public virtual IResult Delete(int id)
        {
            _baseRepository.Delete(id);
            return Results.Ok();
        }
    }
}
