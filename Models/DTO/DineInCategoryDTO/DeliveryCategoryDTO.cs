using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DineInCategory
{
    // create a cateogry with self referencing

    public class DineInCategoryDTO
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } = "";
        public DineInCategoryParentDTO? ParentCategory { get; set; }
        public List<DineInCategoryDTO> SubCategories { get; set; }
    }
}