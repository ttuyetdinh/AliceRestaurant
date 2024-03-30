using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;

namespace AliceRestaurant.Models
{
    public class RestaurantDTO
    {
        public int RestaurantId { get; set; }
        public string? Name { get; set; } = "";
        public ICollection<RestaurantDish>? RestaurantDishes { get; set; }
    }
}