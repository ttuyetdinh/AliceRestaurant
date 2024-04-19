using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.ChangeLogDTO;
using AliceRestaurant.Models.DTO.DropdownDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class ChangeLogMapper
    {
        public static void ApplyChangeLogMapping(this IMapperConfigurationExpression config)
        {
            config.CreateMap<ChangeLog, ChangeLogDTO>().ReverseMap();
        }
    }
}