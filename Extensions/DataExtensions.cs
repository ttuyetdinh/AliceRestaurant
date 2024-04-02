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
            modelBuilder.SeedRestaurantDish();
            modelBuilder.SeedDish();
        }
        public static void SeedDineInCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DineInCategory>().HasData(
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
            );
        }

        public static void SeedDeliveryCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeliveryCategory>().HasData(
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
            );
        }
        public static void SeedRestaurant(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
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
            );
        }

        public static void SeedRestaurantDish(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantDish>().HasData(
                new RestaurantDish
                {
                    DishId = 1,
                    RestaurantId = 1,
                },
                new RestaurantDish
                {
                    DishId = 2,
                    RestaurantId = 1,
                },
                new RestaurantDish
                {
                    DishId = 3,
                    RestaurantId = 1,
                },

                new RestaurantDish
                {
                    DishId = 1,
                    RestaurantId = 2,
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
            );
        }

        public static void SeedDish(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    DishId = 1,
                    DineInCategoryId = 1,
                    DeliveryCategoryId = 1,
                    RestaurantId = 1,
                    DishName = "Dish 1",
                    ShortName = "D1",
                    EnglishName = "Dish One",
                    KoreanName = "Dish One",
                    Price = 10.00,
                    Description = "Dish One Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    SellingDate = DateTime.Now,
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                },
                new Dish
                {
                    DishId = 2,
                    DineInCategoryId = 2,
                    DeliveryCategoryId = 2,
                    RestaurantId = 2,
                    DishName = "Dish 2",
                    ShortName = "D2",
                    EnglishName = "Dish Two",
                    KoreanName = "Dish Two",
                    Price = 20.00,
                    Description = "Dish Two Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    SellingDate = DateTime.Now,
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                },
                new Dish
                {
                    DishId = 3,
                    DineInCategoryId = 3,
                    DeliveryCategoryId = 3,
                    RestaurantId = 3,
                    DishName = "Dish 3",
                    ShortName = "D3",
                    EnglishName = "Dish Three",
                    KoreanName = "Dish Three",
                    Price = 30.00,
                    Description = "Dish Three Description",
                    Allergy = "Allergy",
                    DineInType = "DineIn",
                    DeliveryType = "Delivery",
                    SellingDate = DateTime.Now,
                    IsAvailable = true,
                    ImageUrl = "https://www.google.com",
                }
            );
        }
    }
}