using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<DeliveryMenu>
    {
        public void Configure(EntityTypeBuilder<DeliveryMenu> builder)
        {
            // create self referencing relationship
            builder.HasOne<DeliveryMenu>(e => e.ParentMenu)
                .WithMany(d => d.DeliveryMenus)
                .HasForeignKey(e => e.ParentMenuId);
        }
    }
}