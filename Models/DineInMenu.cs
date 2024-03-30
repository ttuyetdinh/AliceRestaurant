using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    // create a cateogry with self referencing
    public class DineInMenu
    {
        [Key]
        public int DineInMenuId { get; set; }
        public int? ParentMenuId { get; set; } //  foreign key to self
        public string? MenuName { get; set; } = "";
        public DineInMenu? ParentMenu { get; set; }
        public List<DineInMenu>? DineInMenus { get; set; }
        public ICollection<Dish>? Dishes { get; set; }

        public DateTime? LastUpdated { get; set; } = DateTime.Now;
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
    }
}