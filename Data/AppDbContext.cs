using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using AliceRestaurant.Models;


// using AnyaStore.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Dish> Dishes { get; set; }

        // create a seed method to add data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // apply the configuration classes to the model builder
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}