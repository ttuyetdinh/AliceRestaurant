using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    // create a cateogry with self referencing
    public class DeliveryMenu
    {
        [Key]
        public int DeliveryMenuId { get; set; }
        public int? ParentMenuId { get; set; } //  foreign key to self
        public string? MenuName { get; set; } = "";
        public DeliveryMenu? ParentMenu { get; set; }
        public List<DeliveryMenu>? DeliveryMenus { get; set; }
        public ICollection<Dish>? Dishes { get; set; }
    }
}