using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AliceRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace AliceRestaurant.Extensions
{
    public static class DataExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDineInCategory();
            modelBuilder.SeedDeliveryCategory();
            modelBuilder.SeedRestaurant();
            modelBuilder.SeedDish();
            modelBuilder.SeedRestaurantDish();
            modelBuilder.SeedDropDown();
        }
        public static void SeedDineInCategory(this ModelBuilder modelBuilder)
        {
            var seedDineIn = new List<DineInCategory>(){
                new DineInCategory
                {
                    DineInCategoryId = 1,
                    CategoryName = "DineIn 1",
                },
                new DineInCategory
                {
                    DineInCategoryId = 2,
                    CategoryName = "DineIn 2",
                },
                new DineInCategory
                {
                    DineInCategoryId = 3,
                    ParentCategoryId = 1,
                    CategoryName = "Sub DineIn A",
                },
                new DineInCategory
                {
                    DineInCategoryId = 4,
                    ParentCategoryId = 1,
                    CategoryName = "Sub DineIn B",
                },
                new DineInCategory
                {
                    DineInCategoryId = 5,
                    ParentCategoryId = 2,
                    CategoryName = "Sub DineIn C",
                }
            };

            seedDineIn.ForEach(u =>
            {
                u.CreatedOn = DateTime.Now;
                u.LastUpdated = DateTime.Now;
            });

            modelBuilder.Entity<DineInCategory>().HasData(seedDineIn);
        }

        public static void SeedDeliveryCategory(this ModelBuilder modelBuilder)
        {
            var seedDelivery = new List<DeliveryCategory>(){
                new DeliveryCategory
                {
                    DeliveryCategoryId = 1,
                    CategoryName = "Delivery 1",
                },
                new DeliveryCategory
                {
                    DeliveryCategoryId = 2,
                    CategoryName = "Delivery 2",
                },
                new DeliveryCategory
                {
                    DeliveryCategoryId = 3,
                    ParentCategoryId = 1,
                    CategoryName = "Sub Delivery A",
                },
                new DeliveryCategory
                {
                    DeliveryCategoryId = 4,
                    ParentCategoryId = 1,
                    CategoryName = "Sub Delivery B",
                },
                new DeliveryCategory
                {
                    DeliveryCategoryId = 5,
                    ParentCategoryId = 2,
                    CategoryName = "Sub Delivery C",
                }
            };

            seedDelivery.ForEach(u =>
            {
                u.CreatedOn = DateTime.Now;
                u.LastUpdated = DateTime.Now;
            });

            modelBuilder.Entity<DeliveryCategory>().HasData(seedDelivery);
        }
        public static void SeedRestaurant(this ModelBuilder modelBuilder)
        {
            var seedRestaurant = new List<Restaurant>(){
                new Restaurant
                {
                    RestaurantId = 1,
                    Name = "Restaurant 1",
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Restaurant 2",
                },
                new Restaurant
                {
                    RestaurantId = 3,
                    Name = "Restaurant 3",
                }

            };
            seedRestaurant.ForEach(u =>
            {
                u.CreatedOn = DateTime.Now;
                u.LastUpdated = DateTime.Now;
            });

            modelBuilder.Entity<Restaurant>().HasData(seedRestaurant);
        }

        public static void SeedDish(this ModelBuilder modelBuilder)
        {
            var seedDish = new List<Dish>(){

                new Dish
                {
                    DishId = 1,
                    DineInCategoryId = 3,
                    DeliveryCategoryId = 3,
                    DishName = "Dish 1",
                    ShortName = "D1",
                    EnglishName = "Dish One",
                    KoreanName = "Dish One",
                    Price = 10.00,
                    Description = "Dish One Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                },
                new Dish
                {
                    DishId = 2,
                    DineInCategoryId = 4,
                    DeliveryCategoryId = 4,
                    DishName = "Dish 2",
                    ShortName = "D2",
                    EnglishName = "Dish Two",
                    KoreanName = "Dish Two",
                    Price = 20.00,
                    Description = "Dish Two Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                },
                new Dish
                {
                    DishId = 3,
                    DineInCategoryId = 5,
                    DeliveryCategoryId = 5,
                    DishName = "Dish 3",
                    ShortName = "D3",
                    EnglishName = "Dish Three",
                    KoreanName = "Dish Three",
                    Price = 30.00,
                    Description = "Dish Three Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                }
            };

            seedDish.ForEach(u =>
            {
                u.CreatedOn = DateTime.Now;
                u.LastUpdated = DateTime.Now;
            });

            modelBuilder.Entity<Dish>().HasData(seedDish);
        }

        public static void SeedRestaurantDish(this ModelBuilder modelBuilder)
        {
            var seedRestaurantDish = new List<RestaurantDish>(){
                new RestaurantDish
                {
                    DishId = 1,
                    RestaurantId = 1,
                },
                new RestaurantDish
                {
                    DishId = 2,
                    RestaurantId = 2,
                },
                new RestaurantDish
                {
                    DishId = 3,
                    RestaurantId = 3,
                }
            };

            seedRestaurantDish.ForEach(u =>
            {
                u.CreatedOn = DateTime.Now;
                u.LastUpdated = DateTime.Now;
            });

            modelBuilder.Entity<RestaurantDish>().HasData(seedRestaurantDish);
        }

        public static void SeedDropDown(this ModelBuilder modelBuilder)
        {
            var seedDropDown = new List<Dropdown>(){
                new Dropdown
                {
                    DropdownId = 1,
                    Name = "Core",
                    Value = "Core",
                    Type = "DishType",
                    Module = "DineIn",
                    Description = "A core dish in Dine Menu",
                },
                new Dropdown
                {
                    DropdownId = 2,
                    Name = "Seasonal",
                    Value = "Seasonal",
                    Type = "DishType",
                    Module = "DineIn",
                    Description = "A seasonal dish in Dine Menu",
                },
                new Dropdown
                {
                    DropdownId = 3,
                    Name = "Core",
                    Value = "Core",
                    Type = "DishType",
                    Module = "Delivery",
                    Description = "A core dish in Dine Menu",
                },
                new Dropdown
                {
                    DropdownId = 4,
                    Name = "Seasonal",
                    Value = "Seasonal",
                    Type = "DishType",
                    Module = "Delivery",
                    Description = "A seasonal dish in Dine Menu",
                },
            };

            modelBuilder.Entity<Dropdown>().HasData(seedDropDown);
        }
    }
}