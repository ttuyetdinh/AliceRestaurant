using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.Dish;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class DishMapper
    {
        public static void ApplyDishMapping(this IMapperConfigurationExpression config)
        {
            config.CreateMap<Dish, DishDTO>()
                .ForMember(
                    dest => dest.Restaurants,
                    opt => opt.MapFrom(src => src.RestaurantDishes.Select(rd => rd.Restaurant).ToList())
                );

            config.CreateMap<DishUpdateDTO, Dish>();

            config.CreateMap<DishCreateDTO, Dish>();

            config.CreateMap<Restaurant, DishRestaurantDTO>();
            config.CreateMap<DineInCategory, DishDineInCategoryDTO>()
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.DineInCategoryId)
                );
            config.CreateMap<DeliveryCategory, DishDeliveryCategoryDTO>()
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.DeliveryCategoryId)
                );
        }
    }
}