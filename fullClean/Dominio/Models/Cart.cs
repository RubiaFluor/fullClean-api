
using System.ComponentModel.DataAnnotations;

namespace fullClean.Dominio.Models
{
    public class Cart
    {
        [Key]
        public int cartId { get; set; }
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        public string nameproduct { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
    }
}
