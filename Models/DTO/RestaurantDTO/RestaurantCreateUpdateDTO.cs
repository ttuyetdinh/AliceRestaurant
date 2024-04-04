using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models.DTO;

namespace AliceRestaurant.Models.DTO.RestaurantDTO
{
    public class RestaurantCreateUpdateDTO
    {
        [Required]
        public string? Name { get; set; }
    }
}