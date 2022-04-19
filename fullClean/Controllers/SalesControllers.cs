using System;
using System.Threading.Tasks;
using AutoMapper;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;
using fullClean.Dto;
using Microsoft.AspNetCore.Mvc;

namespace fullClean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesControllers : Controller
    {
        private readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;
        public SalesControllers(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddSales(SalesDto salesDto)
        {
            var salesModel = _mapper.Map<SaleModel>(salesDto);
            await _unitOfWork.sales.AddT(salesModel);
            _unitOfWork.saveData();
            return Ok();
            
        }
    }
}
