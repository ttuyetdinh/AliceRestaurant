using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class dish_price_default_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Dishes",
                type: "decimal(18,2)",
                nullable: true,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3135), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3136), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3063), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3171), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 4, 4, 16, 6, 21, 138, DateTimeKind.Local).AddTicks(3174) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Dishes",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldDefaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8285), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8210), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8319), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 4, 4, 16, 2, 5, 702, DateTimeKind.Local).AddTicks(8322) });
        }
    }
}
