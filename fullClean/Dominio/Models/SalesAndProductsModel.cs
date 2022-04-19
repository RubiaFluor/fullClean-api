using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace fullClean.Dominio.Models
{
    public class SalesAndProductsModel
    {
        public int ProductsId { get; set; }
        public int SalesId { get; set; }

        public int QuantityProduct { get; set; }

        //propiedades de navegacion
        [ForeignKey("ProductsId")]
        public ProductModel Products { get; set; }

        [ForeignKey("SalesId")]
        public SaleModel Sales { get; set; }
    }
}
