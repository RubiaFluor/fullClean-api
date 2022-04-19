using System;
using System.Collections.Generic;

namespace fullClean.Dominio.Models
{
    public class SaleModel
    {
        public int id { get; set; }
        public DateTime DateSale { get; set; }
        public decimal TotalPrice { get; set; }
        public List<SalesAndProductsModel> SalesAndProducts { get; set; }
    }
}
