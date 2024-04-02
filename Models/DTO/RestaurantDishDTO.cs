using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO
{
    public class RestaurantDishDTO
    {
        public int DishId { get; set; }
        public int RestaurantId { get; set; }
        public DishDTO Dish { get; set; }
        public RestaurantDTO Restaurant { get; set; }
    }
}