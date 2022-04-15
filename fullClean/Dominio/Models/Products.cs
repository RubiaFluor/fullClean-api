using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fullClean.Dominio.Models
{
    public class Products
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        [Required]
        public string nameproduct { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int stockstore { get; set; }
        [Required]
        public int stockwarehouse { get; set; }
        public List<SalesAndProducts> salesAndProducts { get; set; }
    }
}
