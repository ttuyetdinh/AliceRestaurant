using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class seed_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeliveryCategories",
                columns: new[] { "DeliveryCategoryId", "CategoryName", "CreatedOn", "LastUpdated", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Delivery 1", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9050), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9051), null },
                    { 2, "Delivery 2", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9054), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9054), null }
                });

            migrationBuilder.InsertData(
                table: "DineInCategories",
                columns: new[] { "DineInCategoryId", "CategoryName", "CreatedOn", "LastUpdated", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "DineIn 1", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8859), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8877), null },
                    { 2, "DineIn 2", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8879), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8880), null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "CreatedOn", "LastUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9118), "Restaurant 1" },
                    { 2, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9120), "Restaurant 2" },
                    { 3, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9120), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9121), "Restaurant 3" }
                });

            migrationBuilder.InsertData(
                table: "DeliveryCategories",
                columns: new[] { "DeliveryCategoryId", "CategoryName", "CreatedOn", "LastUpdated", "ParentCategoryId" },
                values: new object[,]
                {
                    { 3, "Sub Delivery A", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9055), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9055), 1 },
                    { 4, "Sub Delivery B", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9056), 1 },
                    { 5, "Sub Delivery C", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9057), 2 }
                });

            migrationBuilder.InsertData(
                table: "DineInCategories",
                columns: new[] { "DineInCategoryId", "CategoryName", "CreatedOn", "LastUpdated", "ParentCategoryId" },
                values: new object[,]
                {
                    { 3, "Sub DineIn A", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8881), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8881), 1 },
                    { 4, "Sub DineIn B", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8882), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8882), 1 },
                    { 5, "Sub DineIn C", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(8883), 2 }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Allergy", "CreatedOn", "DeliveryCategoryId", "DeliveryType", "Description", "DineInCategoryId", "DineInType", "DishName", "EnglishName", "ImageUrl", "IsAvailable", "KoreanName", "LastUpdated", "Price", "RestaurantId", "SellingDate", "ShortName" },
                values: new object[,]
                {
                    { 1, "Allergy", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9185), 1, "Delivery", "Dish One Description", 1, "DineIn", "Dish 1", "Dish One", "https://www.google.com", true, "Dish One", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9187), 10m, 1, null, "D1" },
                    { 2, "Allergy", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9188), 2, "Delivery", "Dish Two Description", 2, "DineIn", "Dish 2", "Dish Two", "https://www.google.com", true, "Dish Two", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9188), 20m, 2, null, "D2" },
                    { 3, "Allergy", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9189), 3, "Delivery", "Dish Three Description", 3, "DineIn", "Dish 3", "Dish Three", "https://www.google.com", true, "Dish Three", new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9189), 30m, 3, null, "D3" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantDishes",
                columns: new[] { "DishId", "RestaurantId", "CreatedOn", "LastUpdated" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9411), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9412) },
                    { 2, 2, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9415) },
                    { 3, 3, new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9415), new DateTime(2024, 4, 2, 16, 1, 49, 333, DateTimeKind.Local).AddTicks(9416) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RestaurantDishes",
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
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1);
        }
    }
}
