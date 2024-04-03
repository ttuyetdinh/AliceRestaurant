using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<DeliveryCategory>
    {
        public void Configure(EntityTypeBuilder<DeliveryCategory> entity)
        {
            // create self referencing relationship
            entity.HasOne<DeliveryCategory>(e => e.ParentCategory)
                .WithMany(d => d.DeliveryCategories)
                .HasForeignKey(e => e.ParentCategoryId);
        }
    }
}