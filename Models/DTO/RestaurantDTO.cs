using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;

namespace AliceRestaurant.Models.DTO
{
    public class RestaurantDTO
    {
        public int RestaurantId { get; set; }
        public string? Name { get; set; } = "";
        public ICollection<RestaurantDishDTO>? RestaurantDishes { get; set; }
    }
}