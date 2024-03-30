using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    internal class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {

            builder.Property(d => d.Price).HasColumnType("decimal(18,2)");

            builder.HasOne<DineInMenu>(e => e.DineInMenu)
                .WithMany(d => d.Dishes)
                .HasForeignKey(e => e.DineInMenuId);

            builder.HasOne<DeliveryMenu>(e => e.DeliveryMenu)
                .WithMany(d => d.Dishes)
                .HasForeignKey(e => e.DeliveryMenuId);
        }
    }
}