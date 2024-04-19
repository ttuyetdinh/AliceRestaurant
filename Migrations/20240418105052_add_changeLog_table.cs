using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class add_changeLog_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishHistories");

            migrationBuilder.CreateTable(
                name: "ChangeLog",
                columns: table => new
                {
                    ChangeLogId = table.Column<int>(type: "int", nullable: false),
                    ChangeLogItem = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: true),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLog", x => new { x.ChangeLogId, x.ChangeLogItem });
                });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8525), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8528), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8435), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8437), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8609), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 4, 18, 17, 50, 52, 158, DateTimeKind.Local).AddTicks(8564) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChangeLog");

            migrationBuilder.CreateTable(
                name: "DishHistories",
                columns: table => new
                {
                    DishHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allergy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryCategoryId = table.Column<int>(type: "int", nullable: false),
                    DeliveryCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DineInCategoryId = table.Column<int>(type: "int", nullable: false),
                    DineInCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DineInType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    KoreanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
