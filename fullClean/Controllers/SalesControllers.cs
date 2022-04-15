using System;
using System.Threading.Tasks;
using AutoMapper;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;
using fullClean.Dto;
using Microsoft.AspNetCore.Mvc;

namespace fullClean.Controllers
{
    public class SalesControllers : Controller
    {
        private readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;
        public SalesControllers(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost("api/[controller]/AddSales")]
        public async Task<ActionResult<UpsertSalesDto>> AddSales(UpsertSalesDto upsertSalesDto)
        {
            var salesModel = _mapper.Map<Sales>(upsertSalesDto);
            await _unitOfWork.sales.AddT(salesModel);
            _unitOfWork.saveData();
            return upsertSalesDto;
            
        }
    }
}
