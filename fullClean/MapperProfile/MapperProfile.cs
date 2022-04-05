using System;
using AutoMapper;
using fullClean.Dominio.Models;
using fullClean.Dto;

namespace fullClean.MapperProfile
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductDto, Products>().ReverseMap();
        }
    }
}
