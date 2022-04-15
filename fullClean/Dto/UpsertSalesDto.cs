using System;
using System.Collections.Generic;
using fullClean.Infractucture.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace fullClean.Dto
{
    public class UpsertSalesDto
    {
        // revisar
        [ModelBinder(BinderType = typeof (CustomModelBinder<List<int>>))]
        public List<int> productsIds { get; set; } // se guardaran all los ids de productos
        public int salesId { get; set; }
        //public string codproduct { get; set; }
        //public string detailproduct { get; set; }
        //public string nameproduct { get; set; }
        //public int price { get; set; }
        //public int quantity { get; set; }

    }
}
