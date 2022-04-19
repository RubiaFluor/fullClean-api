using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fullClean.Dominio.Models
{
    public class ProductModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Detail { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int StockStore { get; set; }
        [Required]
        public int StockWarehouse { get; set; }
        public List<SalesAndProductsModel> SalesAndProducts { get; set; }
    }
}
