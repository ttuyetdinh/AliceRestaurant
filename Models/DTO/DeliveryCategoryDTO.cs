using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    // create a cateogry with self referencing
    public class DeliveryCategoryDTO
    {
        [Key]
        public int DeliveryCategoryId { get; set; }
        public int? ParentCategoryId { get; set; } //  foreign key to self
        public string? CategoryName { get; set; } = "";
        public DeliveryCategory? ParentCategory { get; set; }
        public ICollection<DeliveryCategory>? DeliveryCategories { get; set; }
        public ICollection<Dish>? Dishes { get; set; }
    }
}