using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    internal class DineInMenuConfiguration : IEntityTypeConfiguration<DineInMenu>
    {
        public void Configure(EntityTypeBuilder<DineInMenu> builder)
        {
            builder.HasOne<DineInMenu>(e => e.ParentMenu)
                .WithMany(d => d.DineInMenus)
                .HasForeignKey(e => e.ParentMenuId);
        }
    }
}