using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models.DTO.DropdownDTO
{
    public class DropdownDTO
    {
        public int DropdownId { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }  // a type of dropdown in  a specific section. Ex: PaymentType, OrderStatus, OrderType, ...
        public string? Module { get; set; } // a section in web-page. Ex: Delivery, DineIn, POS, admin,...
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}