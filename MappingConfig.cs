using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AutoMapper;

namespace AliceRestaurant
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Dish, DishDTO>().ReverseMap();
                config.CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
                config.CreateMap<RestaurantDish, RestaurantDishDTO>().ReverseMap();
                config.CreateMap<DeliveryCategory, DeliveryCategoryDTO>().ReverseMap();
                config.CreateMap<DineInCategory, DineInCategoryDTO>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}