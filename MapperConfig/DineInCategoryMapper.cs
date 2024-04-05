using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DineInCategoryDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class DineInCategoryMapper
    {
        public static void ApplyDineInCategoryMapping(this IMapperConfigurationExpression config)
        {
            // For DiningCategory
            config.CreateMap<DineInCategory, DineInCategoryDTO>()
                .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DineInCategoryId))
                .ForMember(dest => dest.ParentCategory, otp => otp.MapFrom(src => src.ParentCategory))
                .ForMember(dest => dest.SubCategories, otp => otp.MapFrom(src => src.DineInCategories));

            config.CreateMap<DineInCategory, DineInCategoryParentDTO>()
                .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DineInCategoryId));

            config.CreateMap<DineInCategoryCUDTO, DineInCategory>();
        }
    }
}