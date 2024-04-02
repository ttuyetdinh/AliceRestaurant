using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class rename_model_field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCategories_DeliveryCategories_ParentMenuId",
                table: "DeliveryCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_DineInCategories_DineInCategories_ParentMenuId",
                table: "DineInCategories");

            migrationBuilder.RenameColumn(
                name: "ParentMenuId",
                table: "DineInCategories",
                newName: "ParentCategoryId");

            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "DineInCategories",
                newName: "CategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_DineInCategories_ParentMenuId",
                table: "DineInCategories",
                newName: "IX_DineInCategories_ParentCategoryId");

            migrationBuilder.RenameColumn(
                name: "ParentMenuId",
                table: "DeliveryCategories",
                newName: "ParentCategoryId");

            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "DeliveryCategories",
                newName: "CategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCategories_ParentMenuId",
                table: "DeliveryCategories",
                newName: "IX_DeliveryCategories_ParentCategoryId");

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2825), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2829), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2831), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2699), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2702), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2703), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2705), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2706), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2927), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2937), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2937), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2941), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2893), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2860), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2863), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 4, 2, 15, 12, 12, 206, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCategories_DeliveryCategories_ParentCategoryId",
                table: "DeliveryCategories",
                column: "ParentCategoryId",
                principalTable: "DeliveryCategories",
                principalColumn: "DeliveryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DineInCategories_DineInCategories_ParentCategoryId",
                table: "DineInCategories",
                column: "ParentCategoryId",
                principalTable: "DineInCategories",
                principalColumn: "DineInCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCategories_DeliveryCategories_ParentCategoryId",
                table: "DeliveryCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_DineInCategories_DineInCategories_ParentCategoryId",
                table: "DineInCategories");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryId",
                table: "DineInCategories",
                newName: "ParentMenuId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "DineInCategories",
                newName: "MenuName");

            migrationBuilder.RenameIndex(
                name: "IX_DineInCategories_ParentCategoryId",
                table: "DineInCategories",
                newName: "IX_DineInCategories_ParentMenuId");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryId",
                table: "DeliveryCategories",
                newName: "ParentMenuId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "DeliveryCategories",
                newName: "MenuName");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCategories_ParentCategoryId",
                table: "DeliveryCategories",
                newName: "IX_DeliveryCategories_ParentMenuId");

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "DeliveryCategories",
                keyColumn: "DeliveryCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7046), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "DineInCategories",
                keyColumn: "DineInCategoryId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7332), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7243), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7241), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7246), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7212), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCategories_DeliveryCategories_ParentMenuId",
                table: "DeliveryCategories",
                column: "ParentMenuId",
                principalTable: "DeliveryCategories",
                principalColumn: "DeliveryCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DineInCategories_DineInCategories_ParentMenuId",
                table: "DineInCategories",
                column: "ParentMenuId",
                principalTable: "DineInCategories",
                principalColumn: "DineInCategoryId");
        }
    }
}
