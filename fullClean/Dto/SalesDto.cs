using System;
using System.Collections.Generic;
using fullClean.Dominio.Models;

namespace fullClean.Dto
{
    public class SalesDto
    {
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        public string nameproduct { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public List<SalesAndProducts> SalesAndProductslist { get; set; }
    }
}
