using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DishDTO
{
    public class DishRestaurantDTO
    {
        public int RestaurantId { get; set; }
        public string? Name { get; set; } = "";
    }
}