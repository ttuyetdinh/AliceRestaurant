using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DishDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class DishHistoryMapper
    {
        public static void ApplyDishHistoryMapping(this IMapperConfigurationExpression config)
        {
            config.CreateMap<DishDTO, DishHistory>()
            .ForMember(
                dest => dest.DineInCategoryName,
                opt => opt.MapFrom(src => src.DineInCategory.CategoryName)
            )
            .ForMember(
                dest => dest.DeliveryCategoryName,
                opt => opt.MapFrom(src => src.DeliveryCategory.CategoryName)
            );

            config.CreateMap<Dish, DishHistory>()
            .ForMember(
                dest => dest.DineInCategoryName,
                opt => opt.MapFrom(src => src.DineInCategory.CategoryName)
            )
            .ForMember(
                dest => dest.DeliveryCategoryName,
                opt => opt.MapFrom(src => src.DeliveryCategory.CategoryName)
            );

        }
    }
}