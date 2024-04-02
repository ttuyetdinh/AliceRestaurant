using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;

namespace AliceRestaurant.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string? Name { get; set; } = "";
        public ICollection<RestaurantDish>? RestaurantDishes { get; set; }

        public DateTime? LastUpdated { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}