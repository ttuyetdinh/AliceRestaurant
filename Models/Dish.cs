using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        public int DineInCategoryId { get; set; } // foreign key
        public int DeliveryCategoryId { get; set; } // foreign key
        [Required]
        public string? DishName { get; set; } = "";
        public string? ShortName { get; set; } = "";
        public string? EnglishName { get; set; } = "";
        public string? KoreanName { get; set; } = "";
        public double? Price { get; set; } = 0.0;
        public string? Description { get; set; } = "";
        public string? Allergy { get; set; } = "";
        public string? DineInType { get; set; } = "";
        public string? DeliveryType { get; set; } = "";
        public DateTime? SellingDate { get; set; }
        public bool? IsAvailable { get; set; } = true;
        public string? ImageUrl { get; set; } = "";
        public DineInCategory? DineInCategory { get; set; }
        public DeliveryCategory? DeliveryCategory { get; set; }
        public ICollection<RestaurantDish>? RestaurantDishes { get; set; }

        public DateTime? LastUpdated { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}