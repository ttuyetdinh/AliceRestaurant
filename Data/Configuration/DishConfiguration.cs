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
        public void Configure(EntityTypeBuilder<Dish> entity)
        {

            entity.Property(d => d.Price).HasColumnType("decimal(18,2)");

            entity.HasOne<DineInCategory>(e => e.DineInCategory)
                .WithMany(d => d.Dishes)
                .HasForeignKey(e => e.DineInCategoryId);

            entity.HasOne<DeliveryCategory>(e => e.DeliveryCategory)
                .WithMany(d => d.Dishes)
                .HasForeignKey(e => e.DeliveryCategoryId);
        }
    }
}