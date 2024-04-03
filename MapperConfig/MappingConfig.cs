using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.MapperConfig;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO;
using AliceRestaurant.Models.DTO.DeliveryCategoryDTO;
using AliceRestaurant.Models.DTO.DineInCategory;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AliceRestaurant.MapperConfig
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.ApplyDishMapping();
                config.ApplyRestaurantMapping();
                config.ApplyDropdownMapping();

                // For DeliveryCategory
                config.CreateMap<DeliveryCategory, DeliveryCategoryDTO>()
                    .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DeliveryCategoryId))
                    .ForMember(dest => dest.ParentCategory, otp => otp.MapFrom(src => src.ParentCategory))
                    .ForMember(dest => dest.SubCategories, otp => otp.MapFrom(src => src.DeliveryCategories));

                config.CreateMap<DeliveryCategory, DeliveryCategoryParentDTO>()
                    .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DeliveryCategoryId));

                // For DiningCategory
                config.CreateMap<DineInCategory, DineInCategoryDTO>()
                    .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DineInCategoryId))
                    .ForMember(dest => dest.ParentCategory, otp => otp.MapFrom(src => src.ParentCategory))
                    .ForMember(dest => dest.SubCategories, otp => otp.MapFrom(src => src.DineInCategories));

                config.CreateMap<DineInCategory, DineInCategoryParentDTO>()
                    .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DineInCategoryId));
            });

            return mappingConfig;
        }
    }
}