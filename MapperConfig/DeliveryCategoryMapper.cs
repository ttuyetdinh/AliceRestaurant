using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using AliceRestaurant.Models.DTO.DeliveryCategoryDTO;
using AutoMapper;

namespace AliceRestaurant.MapperConfig
{
    public static class DeliveryCategoryMapper
    {
        public static void ApplyDeliveryCategoryMapping(this IMapperConfigurationExpression config)
        {
            // For DeliveryCategory
            config.CreateMap<DeliveryCategory, DeliveryCategoryDTO>()
                .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DeliveryCategoryId))
                .ForMember(dest => dest.ParentCategory, otp => otp.MapFrom(src => src.ParentCategory))
                .ForMember(dest => dest.SubCategories, otp => otp.MapFrom(src => src.DeliveryCategories));

            config.CreateMap<DeliveryCategory, DeliveryCategoryParentDTO>()
                .ForMember(dest => dest.CategoryId, otp => otp.MapFrom(src => src.DeliveryCategoryId));

            config.CreateMap<DeliveryCategoryCUDTO, DeliveryCategory>();
        }
    }
}