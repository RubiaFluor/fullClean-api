using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fullClean.Dominio.Models
{
    public class  Sales
    {
        [Key]
        public int salesId {get;set;}
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        public string nameproduct { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        [ForeignKey("cartId")]
        public Cart Cart { get; set; }
    }
}
