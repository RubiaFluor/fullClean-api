using System;
using System.Collections.Generic;
using AutoMapper;
using fullClean.Dominio.Models;
using fullClean.Dto;

namespace fullClean.MapperProfile
{
    public class MappingConfiguration
    {
        public static MapperConfiguration registerMap()
        {
            var mapping = new MapperConfiguration(config =>
            {
                config.CreateMap<SaleModel, SalesDto>().ReverseMap()
                .ForMember(x => x.SalesAndProducts, options => options.MapFrom(MapSalesAndProducts));
                config.CreateMap<ProductDto, ProductModel>().ReverseMap();
            });

            List<SalesAndProductsModel> MapSalesAndProducts(SalesDto salesDto, SaleModel salesModel)
            {
                var Result = new List<SalesAndProductsModel>();
                if (salesDto.Products == null) { return Result; }
                foreach( var product in salesDto.Products) //productsId hacia SalesAndProducts
                {
                    Result.Add( new SalesAndProductsModel() 
                    { ProductsId = product.ProductsId, QuantityProduct = product.QuantityProduct});
                }
                return Result;
            }

            return mapping;
        }
    }
}
