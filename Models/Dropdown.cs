using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AliceRestaurant.Models
{
    public class Dropdown
    {
        [Key]
        public int DropdownId { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; } // a type of dropdown in  a specific section. Ex: PaymentType, OrderStatus, OrderType, ...
        public string? Module { get; set; } // a section in web-page. Ex: Delivery, DineIn, POS, admin,...
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}