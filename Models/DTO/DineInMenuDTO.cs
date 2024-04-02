using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    // create a cateogry with self referencing
    public class DineInMenuDTO
    {
        public int DineInMenuId { get; set; }
        public int? ParentMenuId { get; set; } //  foreign key to self
        public string? MenuName { get; set; } = "";
        public DineInMenu? ParentMenu { get; set; }
        public ICollection<DineInMenu>? DineInMenus { get; set; }
        public ICollection<Dish>? Dishes { get; set; }
    }
}