using System;
using System.Threading.Tasks;
using AutoMapper;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;
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
        public async Task<ActionResult<Sales>> AddSales(Sales sales)
        {
            await _unitOfWork.sales.AddT(sales);
            _unitOfWork.saveData();

            return sales;
        }
    }
}
