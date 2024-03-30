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
            modelBuilder.SeedDineInMenu();
            modelBuilder.SeedDeliveryMenu();
            modelBuilder.SeedRestaurant();
            modelBuilder.SeedRestaurantDish();
            modelBuilder.SeedDish();
        }
        public static void SeedDineInMenu(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DineInMenu>().HasData(
                new DineInMenu
                {
                    DineInMenuId = 1,
                    MenuName = "DineIn 1",
                },
                new DineInMenu
                {
                    DineInMenuId = 2,
                    MenuName = "DineIn 2",
                },
                new DineInMenu
                {
                    DineInMenuId = 3,
                    ParentMenuId = 1,
                    MenuName = "Sub DineIn A",
                },
                new DineInMenu
                {
                    DineInMenuId = 4,
                    ParentMenuId = 1,
                    MenuName = "Sub DineIn B",
                },
                new DineInMenu
                {
                    DineInMenuId = 5,
                    ParentMenuId = 2,
                    MenuName = "Sub DineIn C",
                }
            );
        }

        public static void SeedDeliveryMenu(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeliveryMenu>().HasData(
                new DeliveryMenu
                {
                    DeliveryMenuId = 1,
                    MenuName = "Delivery 1",
                },
                new DeliveryMenu
                {
                    DeliveryMenuId = 2,
                    MenuName = "Delivery 2",
                },
                new DeliveryMenu
                {
                    DeliveryMenuId = 3,
                    ParentMenuId = 1,
                    MenuName = "Sub Delivery A",
                },
                new DeliveryMenu
                {
                    DeliveryMenuId = 4,
                    ParentMenuId = 1,
                    MenuName = "Sub Delivery B",
                },
                new DeliveryMenu
                {
                    DeliveryMenuId = 5,
                    ParentMenuId = 2,
                    MenuName = "Sub Delivery C",
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
                    DineInMenuId = 1,
                    DeliveryMenuId = 1,
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
                    DineInMenuId = 2,
                    DeliveryMenuId = 2,
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
                    DineInMenuId = 3,
                    DeliveryMenuId = 3,
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