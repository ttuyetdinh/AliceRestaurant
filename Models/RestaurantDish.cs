using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    public class RestaurantDish
    {
        public int DishId { get; set; }
        public int RestaurantId { get; set; }
        public Dish? Dish { get; set; }
        public Restaurant? Restaurant { get; set; }

        public DateTime? LastUpdated { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}