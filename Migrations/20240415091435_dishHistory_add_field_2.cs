using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class dishHistory_add_field_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryCategoryName",
                table: "DishHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DineInCategoryName",
                table: "DishHistories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4439), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4442), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4281), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4691), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4696), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4533), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4536), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4538), new DateTime(2024, 4, 15, 16, 14, 34, 375, DateTimeKind.Local).AddTicks(4538) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryCategoryName",
                table: "DishHistories");

            migrationBuilder.DropColumn(
                name: "DineInCategoryName",
                table: "DishHistories");

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
    }
}
