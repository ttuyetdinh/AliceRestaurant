using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class dishHistory_add_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "DishHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8756), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8694), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8697), new DateTime(2024, 4, 15, 15, 38, 53, 752, DateTimeKind.Local).AddTicks(8698) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "DishHistories");

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3939), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4136), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4137), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4168), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4170), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4171), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4083), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 4, 15, 15, 36, 41, 994, DateTimeKind.Local).AddTicks(4085) });
        }
    }
}
