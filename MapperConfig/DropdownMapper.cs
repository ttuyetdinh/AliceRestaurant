using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DropdownDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class DropdownMapper
    {
        public static void ApplyDropdownMapping(this IMapperConfigurationExpression config)
        {
            config.CreateMap<Dropdown, DropdownDTO>().ReverseMap();
            config.CreateMap<DropdownCreateDTO, Dropdown>();
            config.CreateMap<DropdownUpdateDTO, Dropdown>();
        }
    }
}