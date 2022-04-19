using System;
namespace fullClean.Dto
{
    public class ProductDto
    {
        public string Code { get; set; }
        public string Detail { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockStore { get; set; }
        public int StockWarehouse { get; set; }
    }
}
