﻿// <auto-generated />
using System;
using AliceRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AliceRestaurant.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403084646_seed_dropdown_table")]
    partial class seed_dropdown_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AliceRestaurant.Models.DeliveryCategory", b =>
                {
                    b.Property<int>("DeliveryCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryCategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("DeliveryCategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("DeliveryCategories");

                    b.HasData(
                        new
                        {
                            DeliveryCategoryId = 1,
                            CategoryName = "Delivery 1",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5691),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5692)
                        },
                        new
                        {
                            DeliveryCategoryId = 2,
                            CategoryName = "Delivery 2",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5693),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5694)
                        },
                        new
                        {
                            DeliveryCategoryId = 3,
                            CategoryName = "Sub Delivery A",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5694),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5695),
                            ParentCategoryId = 1
                        },
                        new
                        {
                            DeliveryCategoryId = 4,
                            CategoryName = "Sub Delivery B",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5695),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5696),
                            ParentCategoryId = 1
                        },
                        new
                        {
                            DeliveryCategoryId = 5,
                            CategoryName = "Sub Delivery C",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5696),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5697),
                            ParentCategoryId = 2
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.DineInCategory", b =>
                {
                    b.Property<int>("DineInCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DineInCategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("DineInCategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("DineInCategories");

                    b.HasData(
                        new
                        {
                            DineInCategoryId = 1,
                            CategoryName = "DineIn 1",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5587),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5600)
                        },
                        new
                        {
                            DineInCategoryId = 2,
                            CategoryName = "DineIn 2",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601)
                        },
                        new
                        {
                            DineInCategoryId = 3,
                            CategoryName = "Sub DineIn A",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5602),
                            ParentCategoryId = 1
                        },
                        new
                        {
                            DineInCategoryId = 4,
                            CategoryName = "Sub DineIn B",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5602),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5603),
                            ParentCategoryId = 1
                        },
                        new
                        {
                            DineInCategoryId = 5,
                            CategoryName = "Sub DineIn C",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5603),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5604),
                            ParentCategoryId = 2
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DishId"));

                    b.Property<string>("Allergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DineInCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DineInType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("KoreanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("SellingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DishId");

                    b.HasIndex("DeliveryCategoryId");

                    b.HasIndex("DineInCategoryId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            Allergy = "Allergy",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5777),
                            DeliveryCategoryId = 3,
                            DeliveryType = "Delivery",
                            Description = "Dish One Description",
                            DineInCategoryId = 3,
                            DineInType = "DineIn",
                            DishName = "Dish 1",
                            EnglishName = "Dish One",
                            ImageUrl = "https://www.google.com",
                            IsAvailable = true,
                            KoreanName = "Dish One",
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5778),
                            Price = 10m,
                            ShortName = "D1"
                        },
                        new
                        {
                            DishId = 2,
                            Allergy = "Allergy",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5779),
                            DeliveryCategoryId = 4,
                            DeliveryType = "Delivery",
                            Description = "Dish Two Description",
                            DineInCategoryId = 4,
                            DineInType = "DineIn",
                            DishName = "Dish 2",
                            EnglishName = "Dish Two",
                            ImageUrl = "https://www.google.com",
                            IsAvailable = true,
                            KoreanName = "Dish Two",
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780),
                            Price = 20m,
                            ShortName = "D2"
                        },
                        new
                        {
                            DishId = 3,
                            Allergy = "Allergy",
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780),
                            DeliveryCategoryId = 5,
                            DeliveryType = "Delivery",
                            Description = "Dish Three Description",
                            DineInCategoryId = 5,
                            DineInType = "DineIn",
                            DishName = "Dish 3",
                            EnglishName = "Dish Three",
                            ImageUrl = "https://www.google.com",
                            IsAvailable = true,
                            KoreanName = "Dish Three",
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780),
                            Price = 30m,
                            ShortName = "D3"
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.Dropdown", b =>
                {
                    b.Property<int>("DropdownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DropdownId"));

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Module")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DropdownId");

                    b.ToTable("Dropdown");

                    b.HasData(
                        new
                        {
                            DropdownId = 1,
                            Description = "A core dish in Dine Menu",
                            Module = "DineIn",
                            Name = "Core",
                            Type = "DishType",
                            Value = "Core"
                        },
                        new
                        {
                            DropdownId = 2,
                            Description = "A seasonal dish in Dine Menu",
                            Module = "DineIn",
                            Name = "Seasonal",
                            Type = "DishType",
                            Value = "Seasonal"
                        },
                        new
                        {
                            DropdownId = 3,
                            Description = "A core dish in Dine Menu",
                            Module = "Delivery",
                            Name = "Core",
                            Type = "DishType",
                            Value = "Core"
                        },
                        new
                        {
                            DropdownId = 4,
                            Description = "A seasonal dish in Dine Menu",
                            Module = "Delivery",
                            Name = "Seasonal",
                            Type = "DishType",
                            Value = "Seasonal"
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5735),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5736),
                            Name = "Restaurant 1"
                        },
                        new
                        {
                            RestaurantId = 2,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5736),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5737),
                            Name = "Restaurant 2"
                        },
                        new
                        {
                            RestaurantId = 3,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5737),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5738),
                            Name = "Restaurant 3"
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.RestaurantDish", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("DishId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantDishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            RestaurantId = 1,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5809),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5810)
                        },
                        new
                        {
                            DishId = 2,
                            RestaurantId = 2,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5811),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5811)
                        },
                        new
                        {
                            DishId = 3,
                            RestaurantId = 3,
                            CreatedOn = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5812),
                            LastUpdated = new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5812)
                        });
                });

            modelBuilder.Entity("AliceRestaurant.Models.DeliveryCategory", b =>
                {
                    b.HasOne("AliceRestaurant.Models.DeliveryCategory", "ParentCategory")
                        .WithMany("DeliveryCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("AliceRestaurant.Models.DineInCategory", b =>
                {
                    b.HasOne("AliceRestaurant.Models.DineInCategory", "ParentCategory")
                        .WithMany("DineInCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("AliceRestaurant.Models.Dish", b =>
                {
                    b.HasOne("AliceRestaurant.Models.DeliveryCategory", "DeliveryCategory")
                        .WithMany("Dishes")
                        .HasForeignKey("DeliveryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AliceRestaurant.Models.DineInCategory", "DineInCategory")
                        .WithMany("Dishes")
                        .HasForeignKey("DineInCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryCategory");

                    b.Navigation("DineInCategory");
                });

            modelBuilder.Entity("AliceRestaurant.Models.RestaurantDish", b =>
                {
                    b.HasOne("AliceRestaurant.Models.Dish", "Dish")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AliceRestaurant.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("AliceRestaurant.Models.DeliveryCategory", b =>
                {
                    b.Navigation("DeliveryCategories");

                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("AliceRestaurant.Models.DineInCategory", b =>
                {
                    b.Navigation("DineInCategories");

                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("AliceRestaurant.Models.Dish", b =>
                {
                    b.Navigation("RestaurantDishes");
                });

            modelBuilder.Entity("AliceRestaurant.Models.Restaurant", b =>
                {
                    b.Navigation("RestaurantDishes");
                });
#pragma warning restore 612, 618
        }
    }
}
