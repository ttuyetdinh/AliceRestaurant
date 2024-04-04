using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.Dish
{
    public class DishUpdateDTO
    {

        public int? DineInCategoryId { get; set; } // foreign key
        public int? DeliveryCategoryId { get; set; } // foreign key
        [Required]
        public string? DishName { get; set; }
        public string? ShortName { get; set; }
        public string? EnglishName { get; set; }
        public string? KoreanName { get; set; }
        [Required]
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? Allergy { get; set; }
        public string? DineInType { get; set; }
        public string? DeliveryType { get; set; }
        public DateTime? SellingDate { get; set; }
        [Required]
        public bool? IsAvailable { get; set; }
        public string? ImageUrl { get; set; }
    }
}