using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class dish_not_dependon_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInCategories_DineInCategoryId",
                table: "Dishes");

            migrationBuilder.AlterColumn<int>(
                name: "DineInCategoryId",
                table: "Dishes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryCategoryId",
                table: "Dishes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                table: "Dishes",
                column: "DeliveryCategoryId",
                principalTable: "DeliveryCategories",
                principalColumn: "DeliveryCategoryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DineInCategories_DineInCategoryId",
                table: "Dishes",
                column: "DineInCategoryId",
                principalTable: "DineInCategories",
                principalColumn: "DineInCategoryId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInCategories_DineInCategoryId",
                table: "Dishes");

            migrationBuilder.AlterColumn<int>(
                name: "DineInCategoryId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryCategoryId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(246), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(247), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(249), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(155), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(156), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(157), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(338), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(340), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(379), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(380), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(381), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(288), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(291), new DateTime(2024, 4, 4, 15, 47, 34, 49, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                table: "Dishes",
                column: "DeliveryCategoryId",
                principalTable: "DeliveryCategories",
                principalColumn: "DeliveryCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DineInCategories_DineInCategoryId",
                table: "Dishes",
                column: "DineInCategoryId",
                principalTable: "DineInCategories",
                principalColumn: "DineInCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
