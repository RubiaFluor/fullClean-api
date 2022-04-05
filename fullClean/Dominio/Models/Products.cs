using System;
namespace fullClean.Dominio.Models
{
    public class Products
    {
        public int id { get; set; }
        public string codproduct { get; set; }
        public string detailproduct { get; set; }
        public string nameproduct { get; set; }
        public int price { get; set; }
        public int stockstore { get; set; }
        public int stockwarehouse { get; set; }
    }
}
