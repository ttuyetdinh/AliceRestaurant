using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeliveryMenu",
                columns: new[] { "DeliveryMenuId", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, "Delivery 1", null },
                    { 2, "Delivery 2", null }
                });

            migrationBuilder.InsertData(
                table: "DineInMenu",
                columns: new[] { "DineInMenuId", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, "DineIn 1", null },
                    { 2, "DineIn 2", null }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Name" },
                values: new object[,]
                {
                    { 1, "Restaurant 1" },
                    { 2, "Restaurant 2" },
                    { 3, "Restaurant 3" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryMenu",
                columns: new[] { "DeliveryMenuId", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, "Sub Delivery A", 1 },
                    { 4, "Sub Delivery B", 1 },
                    { 5, "Sub Delivery C", 2 }
                });

            migrationBuilder.InsertData(
                table: "DineInMenu",
                columns: new[] { "DineInMenuId", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, "Sub DineIn A", 1 },
                    { 4, "Sub DineIn B", 1 },
                    { 5, "Sub DineIn C", 2 }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Allergy", "CreatedOn", "DeliveryMenuId", "DeliveryType", "Description", "DineInMenuId", "DineInType", "DishName", "EnglishName", "ImageUrl", "IsAvailable", "KoreanName", "LastUpdated", "Price", "RestaurantId", "SellingDate", "ShortName" },
                values: new object[,]
                {
                    { 1, "Allergy", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9763), 1, "Delivery", "Dish One Description", 1, "DineIn", "Dish 1", "Dish One", "https://www.google.com", true, "Dish One", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9748), 10m, 1, new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9767), "D1" },
                    { 2, "Allergy", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9770), 2, "Delivery", "Dish Two Description", 2, "DineIn", "Dish 2", "Dish Two", "https://www.google.com", true, "Dish Two", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9770), 20m, 2, new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9773), "D2" },
                    { 3, "Allergy", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9774), 3, "Delivery", "Dish Three Description", 3, "DineIn", "Dish 3", "Dish Three", "https://www.google.com", true, "Dish Three", new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9774), 30m, 3, new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9776), "D3" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantDish",
                columns: new[] { "DishId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryMenu",
                keyColumn: "DeliveryMenuId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DeliveryMenu",
                keyColumn: "DeliveryMenuId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DineInMenu",
                keyColumn: "DineInMenuId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DineInMenu",
                keyColumn: "DineInMenuId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RestaurantDish",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryMenu",
                keyColumn: "DeliveryMenuId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryMenu",
                keyColumn: "DeliveryMenuId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DineInMenu",
                keyColumn: "DineInMenuId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DineInMenu",
                keyColumn: "DineInMenuId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryMenu",
                keyColumn: "DeliveryMenuId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DineInMenu",
                keyColumn: "DineInMenuId",
                keyValue: 1);
        }
    }
}
