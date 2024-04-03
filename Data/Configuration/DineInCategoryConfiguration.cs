using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    internal class DineInCategoryConfiguration : IEntityTypeConfiguration<DineInCategory>
    {
        public void Configure(EntityTypeBuilder<DineInCategory> entity)
        {
            entity.HasOne<DineInCategory>(e => e.ParentCategory)
                .WithMany(d => d.DineInCategories)
                .HasForeignKey(e => e.ParentCategoryId);
        }
    }
}