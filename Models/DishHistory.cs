using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Models
{
    // create a model to store the history of dishes table

    public class DishHistory
    {
        [Key]
        public int DishHistoryId { get; set; }
        public int DishId { get; set; }
        public int DineInCategoryId { get; set; } // foreign key
        public int DeliveryCategoryId { get; set; } // foreign key
        [Required]
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
        public DateTime? LastUpdated { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}