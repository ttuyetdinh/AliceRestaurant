using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Data.Configuration
{
    public class RestaurantDishConfiguration : IEntityTypeConfiguration<RestaurantDish>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RestaurantDish> builder)
        {
            builder.HasKey(rd => new { rd.DishId, rd.RestaurantId });
        }
    }
}