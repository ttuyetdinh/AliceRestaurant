using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    public class RestaurantDishConfiguration : IEntityTypeConfiguration<RestaurantDish>
    {
        public void Configure(EntityTypeBuilder<RestaurantDish> entity)
        {
            entity.HasKey(rd => new { rd.DishId, rd.RestaurantId });
        }
    }
}