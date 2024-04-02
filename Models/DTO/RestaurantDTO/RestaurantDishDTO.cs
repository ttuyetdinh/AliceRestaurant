using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.RestaurantDTO
{
    public class RestaurantDishDTO
    {
        public int DishId { get; set; }
        public string? DishName { get; set; }
        public string? ShortName { get; set; }
        public string? EnglishName { get; set; }
        public string? KoreanName { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? Allergy { get; set; }
        public string? DineInType { get; set; }
        public string? DeliveryType { get; set; }
        public DateTime? SellingDate { get; set; }
        public bool? IsAvailable { get; set; }
        public string? ImageUrl { get; set; }
        public RestaurantDineInCategoryDTO? DineInCategory { get; set; }
        public RestaurantDeliveryCategoryDTO? DeliveryCategory { get; set; }
    }
}