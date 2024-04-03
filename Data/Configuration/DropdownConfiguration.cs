using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AliceRestaurant.Data.Configuration
{
    public class DropdownConfiguration : IEntityTypeConfiguration<Dropdown>
    {
        public void Configure(EntityTypeBuilder<Dropdown> entity)
        {
            entity.Property(b => b.IsActive).HasDefaultValue(true);
        }
    }
}