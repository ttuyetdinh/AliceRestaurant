using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DropdownDTO
{
    public class DropdownCreateDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Value { get; set; }
        [Required]
        public string? Type { get; set; }  // a type of dropdown in  a specific section. Ex: PaymentType, OrderStatus, OrderType, ...
        [Required]
        public string? Module { get; set; } // a section in web-page. Ex: Delivery, DineIn, POS, admin,...
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}