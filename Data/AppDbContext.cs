using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AliceRestaurant.Extensions;
using AliceRestaurant.Models;


// using AnyaStore.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<ChangeLog> ChangeLog { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantDish> RestaurantDishes { get; set; }
        public DbSet<DineInCategory> DineInCategories { get; set; }
        public DbSet<DeliveryCategory> DeliveryCategories { get; set; }
        public DbSet<Dropdown> Dropdowns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // apply the configuration classes to the model builder
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // extension method to seed data
            modelBuilder.SeedData();
        }
    }

}