using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class IsActive_dropdown_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dropdown",
                table: "Dropdown");

            migrationBuilder.RenameTable(
                name: "Dropdown",
                newName: "Dropdowns");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Dropdowns",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dropdowns",
                table: "Dropdowns",
                column: "DropdownId");

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
                table: "Dropdowns",
                keyColumn: "DropdownId",
                keyValue: 1,
                columns: new[] { "IsActive", "LastUpdated" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Dropdowns",
                keyColumn: "DropdownId",
                keyValue: 2,
                columns: new[] { "IsActive", "LastUpdated" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Dropdowns",
                keyColumn: "DropdownId",
                keyValue: 3,
                columns: new[] { "IsActive", "LastUpdated" },
                values: new object[] { true, null });

            migrationBuilder.UpdateData(
                table: "Dropdowns",
                keyColumn: "DropdownId",
                keyValue: 4,
                columns: new[] { "IsActive", "LastUpdated" },
                values: new object[] { true, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dropdowns",
                table: "Dropdowns");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Dropdowns");

            migrationBuilder.RenameTable(
                name: "Dropdowns",
                newName: "Dropdown");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dropdown",
                table: "Dropdown",
                column: "DropdownId");

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5811), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5812), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5736), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5737), new DateTime(2024, 4, 3, 15, 46, 46, 342, DateTimeKind.Local).AddTicks(5738) });
        }
    }
}
