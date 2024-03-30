using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    public class RestaurantDishDTO
    {
        public int DishId { get; set; }
        public int RestaurantId { get; set; }
        public Dish Dish { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}