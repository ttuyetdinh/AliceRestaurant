using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class Update_changeLog_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RecordId",
                table: "ChangeLog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(412), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(413), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(414), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(415), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(319), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(535), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 4, 18, 15, 47, 44, 739, DateTimeKind.Local).AddTicks(460) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RecordId",
                table: "ChangeLog",
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
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6408), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6411), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6412), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6333), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6335), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6558), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6587), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 4, 18, 15, 36, 38, 222, DateTimeKind.Local).AddTicks(6510) });
        }
    }
}
