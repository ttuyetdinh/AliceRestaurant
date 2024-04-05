using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DineInCategoryDTO
{
    public class DineInCategoryCUDTO
    {
        public int? ParentCategoryId { get; set; } //  foreign key to self
        [Required]
        public string? CategoryName { get; set; }
    }
}