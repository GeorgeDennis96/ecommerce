﻿using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;
using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService ProductService;

        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> AdminGetProducts()
        {
            var result = await ProductService.ListProducts();
            return Ok(result);  
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct(int id)
        {
            var result = await ProductService.RetrieveProduct(id);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Product>>> DeleteProduct(Product product)
        {
            var result = await ProductService.DeleteProduct(product);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct(Product product)
        {
            var result = await ProductService.CreateProduct(product);

            return Ok(result);
        }
    }
}
