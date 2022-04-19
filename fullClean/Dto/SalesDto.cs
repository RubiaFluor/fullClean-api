using System;
using System.Collections.Generic;
using fullClean.Dominio.Models;
using fullClean.Infractucture.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace fullClean.Dto
{
    public class SalesDto
    {
        public DateTime DateSale { get; set; }
        public decimal TotalPrice { get; set; } 

        //ProductsIds Array  
        [ModelBinder(BinderType = typeof(CustomModelBinder<List<SalesAndProductsModel>>))]
        public List<SalesAndProductsModel> Products { get; set; }
    }
}
