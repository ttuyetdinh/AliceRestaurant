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
        public int DineInMenuId { get; set; } // foreign key
        public int DeliveryMenuId { get; set; } // foreign key
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
        public DateTime? SellingDate { get; set; } = null;
        public bool? IsAvailable { get; set; } = true;
        public string? ImageUrl { get; set; } = "";
        public DateTime? LastUpdated { get; set; } = DateTime.Now;
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }
}