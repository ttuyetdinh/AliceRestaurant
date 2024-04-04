using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class IsAvailable_dish_table_default_true : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Dishes",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Dishes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2030), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2033), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1848), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1869), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1872), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2236), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2101), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 4, 3, 18, 33, 48, 976, DateTimeKind.Local).AddTicks(2103) });
        }
    }
}
