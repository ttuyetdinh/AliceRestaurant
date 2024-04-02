using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DeliveryCategoryDTO
{
    // create a cateogry with self referencing

    public class DeliveryCategoryDTO
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } = "";
        public DeliveryCategoryParentDTO? ParentCategory { get; set; }
        public List<DeliveryCategoryDTO>? SubCategories { get; set; }
    }
}