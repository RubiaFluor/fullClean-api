using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;
using fullClean.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fullClean.Controllers
{
    //[Route("api/[controller]")]
    public class ProductsController : Controller
    { 
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Products>> AddProducts(Products products) {
            await _unitOfWork.products.AddT(products);
            _unitOfWork.saveData();

            return products;
            
        }

        [HttpGet("api/[controller]/getAllProducts")]
        public async Task<List<ProductDto>> getAllProducts()
        {
            var listProduct = await _unitOfWork.products.GetAll();
            var listProductDto = _mapper.Map<List<ProductDto>>(listProduct);
            return listProductDto;
        }
    }
}
