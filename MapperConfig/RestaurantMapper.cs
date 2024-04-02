using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.RestaurantDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class RestaurantMapper
    {
        public static void ApplyRestaurantMapping(this IMapperConfigurationExpression config)
        {
            config.CreateMap<Restaurant, RestaurantDTO>()
                .ForMember(
                    dest => dest.RestaurantDishes,
                    opt => opt.MapFrom(src => src.RestaurantDishes.Select(rd => rd.Dish).ToList())
                );

            config.CreateMap<Dish, RestaurantDishDTO>();
            config.CreateMap<DineInCategory, RestaurantDineInCategoryDTO>()
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.DineInCategoryId)
                );
            config.CreateMap<DeliveryCategory, RestaurantDeliveryCategoryDTO>()
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.DeliveryCategoryId)
                );
        }
    }
}