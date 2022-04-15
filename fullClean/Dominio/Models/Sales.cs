using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fullClean.Dominio.Models
{
    public class  Sales
    {
        [Key]
        public int salesId {get;set;}
        [Required]
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        [Required]
        public string nameproduct { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int quantity { get; set; }
        public List<SalesAndProducts> SalesAndProductslist { get; set; }
    }
}
