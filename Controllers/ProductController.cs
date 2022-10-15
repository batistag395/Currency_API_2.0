﻿using CurrencyAPI.Model;
using CurrencyAPI.Repository;
using CurrencyAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        [HttpGet("GetProducts")]
        public IResult Get()
        {
            return Results.Ok(_productRepository.Get());
        }
        [HttpGet("{id}")]
        public IResult GetById(int id)
        {
            return Results.Ok(_productRepository.GetById(id));
        }
        [HttpPost("AddProduct")]
        public IResult Insert(Product _product)
        {
            _productRepository.Insert(_product);
            return Results.Ok();
        }
        [HttpPost("ConvertProductPrice")]
        public IResult ConvertPrice(string _productName, string _toCurrency, string dailyCurrency)
        {
            return Results.Ok(_productRepository.ConvertProductPrice(_productName, _toCurrency, dailyCurrency));
        }
        [HttpPost("toBuyProduct")]
        public IResult toBuyProduct(string _productName, string _toCurrency, string dailyCurrency, int id)
        {
            return Results.Ok(_productRepository.toBuyProduct(_productName, _toCurrency, dailyCurrency, id));
        }
        [HttpPut("Update Product")]
        public IResult Update(Product _product)
        {
            _productRepository.Update(_product);
            return Results.Ok();
        }
        [HttpDelete("Delete Product")]
        public IResult Delete(string _name)
        {
            _productRepository.Delete(_name);
            return Results.Ok();
        }
    }
}
