using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO.DeliveryCategory;
using AliceRestaurant.Models.DTO.DineInCategory;

namespace AliceRestaurant.Models.DTO
{
    public class DishDTO
    {
        public int DishId { get; set; }
        public int DineInCategoryId { get; set; } // foreign key
        public int DeliveryCategoryId { get; set; } // foreign key
        public int RestaurantId { get; set; } // foreign key
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
        public DineInCategoryDTO? DineInCategory { get; set; }
        public DeliveryCategoryDTO? DeliveryCategory { get; set; }
        public ICollection<RestaurantDishDTO>? RestaurantDishes { get; set; }
    }
}