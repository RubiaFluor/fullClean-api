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
                config.CreateMap<SalesDto, Sales>().ReverseMap();
                config.CreateMap<ProductDto, Products>().ReverseMap();
                config.CreateMap<Sales, UpsertSalesDto>().ReverseMap()
                    .ForMember(x => x.SalesAndProductslist, options => options.MapFrom(salesAndProductsMap));
            
            });
                List<SalesAndProducts> salesAndProductsMap(UpsertSalesDto upsertSalesDto, Sales sales)
                {
                    var result = new List<SalesAndProducts>();
                    if (upsertSalesDto.productsIds == null)
                    {
                        return result;
                    }

                    foreach (var id in upsertSalesDto.productsIds)
                    {
                        result.Add(new SalesAndProducts()
                        {
                            Idproducts = id,

                        });
                    }

                    return result;
                }
            return mapping;

        }
    }
}
