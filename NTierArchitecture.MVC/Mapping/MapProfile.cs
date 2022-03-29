using AutoMapper;
using NTierArchitecture.Entity.Concrete;
using NTierArchitecture.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.MVC.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {


            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Writer, RegisterDto>();
            CreateMap<RegisterDto, Writer>();



        }
    }
}
