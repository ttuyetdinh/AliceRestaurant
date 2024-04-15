using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class dishHistory_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DishHistories",
                columns: table => new
                {
                    DishHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    DineInCategoryId = table.Column<int>(type: "int", nullable: false),
                    DeliveryCategoryId = table.Column<int>(type: "int", nullable: false),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoreanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DineInType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishHistories", x => x.DishHistoryId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishHistories");

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
    }
}
