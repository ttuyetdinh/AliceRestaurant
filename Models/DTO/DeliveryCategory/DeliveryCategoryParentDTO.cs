using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DeliveryCategory
{
    public class DeliveryCategoryParentDTO
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } = "";
    }
}