using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class IsActive_dropdown_table_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Dropdowns",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Dropdowns",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1056), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1059), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1166), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1168), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1169), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1202), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1112), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1113), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1114), new DateTime(2024, 4, 3, 16, 19, 36, 668, DateTimeKind.Local).AddTicks(1115) });
        }
    }
}
