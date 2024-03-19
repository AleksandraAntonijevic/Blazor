﻿using Microsoft.AspNetCore.Mvc;
using Novo.Server.Repositories.Interfaces;
using Novo.Shared.DTO;
using Novo.Shared.Models;

namespace Novo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        [HttpPost("Add-Product")]
        public async Task<ActionResult<ServiceModel<Product>>> AddProduct(Product NewProduct)
        {
            return Ok(await productRepo.AddProduct(NewProduct));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceModel<Product>>> GetProducts()
        {
            return Ok(await productRepo.GetProducts());
        }

        [HttpGet("Get-Product/{ProductId:int}")]
        public async Task<ActionResult<ServiceModel<Product>>> GetProduct(int ProductId)
        {
            return Ok(await productRepo.GetProduct(ProductId));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ServiceModel<Product>>> DeleteProduct(int id)
        {
            return Ok(await productRepo.DeleteProduct(id));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceModel<Product>>> UpdateProduct(Product newProduct)
        {
            return Ok(await productRepo.UpdateProduct(newProduct));
        }
    }
}
