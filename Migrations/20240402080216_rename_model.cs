using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class rename_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryMenus_DeliveryMenuId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInMenus_DineInMenuId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "DeliveryMenus");

            migrationBuilder.DropTable(
                name: "DineInMenus");

            migrationBuilder.RenameColumn(
                name: "DineInMenuId",
                table: "Dishes",
                newName: "DineInCategoryId");

            migrationBuilder.RenameColumn(
                name: "DeliveryMenuId",
                table: "Dishes",
                newName: "DeliveryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_DineInMenuId",
                table: "Dishes",
                newName: "IX_Dishes_DineInCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_DeliveryMenuId",
                table: "Dishes",
                newName: "IX_Dishes_DeliveryCategoryId");

            migrationBuilder.CreateTable(
                name: "DeliveryCategories",
                columns: table => new
                {
                    DeliveryCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCategories", x => x.DeliveryCategoryId);
                    table.ForeignKey(
                        name: "FK_DeliveryCategories_DeliveryCategories_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DeliveryCategories",
                        principalColumn: "DeliveryCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "DineInCategories",
                columns: table => new
                {
                    DineInCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInCategories", x => x.DineInCategoryId);
                    table.ForeignKey(
                        name: "FK_DineInCategories_DineInCategories_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DineInCategories",
                        principalColumn: "DineInCategoryId");
                });

            migrationBuilder.InsertData(
                table: "DeliveryCategories",
                columns: new[] { "DeliveryCategoryId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7170), "Delivery 1", null },
                    { 2, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7176), "Delivery 2", null }
                });

            migrationBuilder.InsertData(
                table: "DineInCategories",
                columns: new[] { "DineInCategoryId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7020), "DineIn 1", null },
                    { 2, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7042), "DineIn 2", null }
                });

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

            migrationBuilder.InsertData(
                table: "DeliveryCategories",
                columns: new[] { "DeliveryCategoryId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7178), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7178), "Sub Delivery A", 1 },
                    { 4, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7179), "Sub Delivery B", 1 },
                    { 5, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7181), "Sub Delivery C", 2 }
                });

            migrationBuilder.InsertData(
                table: "DineInCategories",
                columns: new[] { "DineInCategoryId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7043), "Sub DineIn A", 1 },
                    { 4, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7046), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7045), "Sub DineIn B", 1 },
                    { 5, new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 4, 2, 15, 2, 15, 514, DateTimeKind.Local).AddTicks(7047), "Sub DineIn C", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCategories_ParentMenuId",
                table: "DeliveryCategories",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_DineInCategories_ParentMenuId",
                table: "DineInCategories",
                column: "ParentMenuId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInCategories_DineInCategoryId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "DeliveryCategories");

            migrationBuilder.DropTable(
                name: "DineInCategories");

            migrationBuilder.RenameColumn(
                name: "DineInCategoryId",
                table: "Dishes",
                newName: "DineInMenuId");

            migrationBuilder.RenameColumn(
                name: "DeliveryCategoryId",
                table: "Dishes",
                newName: "DeliveryMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_DineInCategoryId",
                table: "Dishes",
                newName: "IX_Dishes_DineInMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_DeliveryCategoryId",
                table: "Dishes",
                newName: "IX_Dishes_DeliveryMenuId");

            migrationBuilder.CreateTable(
                name: "DeliveryMenus",
                columns: table => new
                {
                    DeliveryMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMenus", x => x.DeliveryMenuId);
                    table.ForeignKey(
                        name: "FK_DeliveryMenus_DeliveryMenus_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DeliveryMenus",
                        principalColumn: "DeliveryMenuId");
                });

            migrationBuilder.CreateTable(
                name: "DineInMenus",
                columns: table => new
                {
                    DineInMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInMenus", x => x.DineInMenuId);
                    table.ForeignKey(
                        name: "FK_DineInMenus_DineInMenus_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DineInMenus",
                        principalColumn: "DineInMenuId");
                });

            migrationBuilder.InsertData(
                table: "DeliveryMenus",
                columns: new[] { "DeliveryMenuId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6704), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6703), "Delivery 1", null },
                    { 2, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6707), "Delivery 2", null }
                });

            migrationBuilder.InsertData(
                table: "DineInMenus",
                columns: new[] { "DineInMenuId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6441), "DineIn 1", null },
                    { 2, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6459), "DineIn 2", null }
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6943), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6857), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "RestaurantDishes",
                keyColumns: new[] { "DishId", "RestaurantId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6760), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.InsertData(
                table: "DeliveryMenus",
                columns: new[] { "DeliveryMenuId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6709), "Sub Delivery A", 1 },
                    { 4, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6710), "Sub Delivery B", 1 },
                    { 5, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6712), "Sub Delivery C", 2 }
                });

            migrationBuilder.InsertData(
                table: "DineInMenus",
                columns: new[] { "DineInMenuId", "CreatedOn", "LastUpdated", "MenuName", "ParentMenuId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6460), "Sub DineIn A", 1 },
                    { 4, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6461), "Sub DineIn B", 1 },
                    { 5, new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6463), "Sub DineIn C", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMenus_ParentMenuId",
                table: "DeliveryMenus",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_DineInMenus_ParentMenuId",
                table: "DineInMenus",
                column: "ParentMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DeliveryMenus_DeliveryMenuId",
                table: "Dishes",
                column: "DeliveryMenuId",
                principalTable: "DeliveryMenus",
                principalColumn: "DeliveryMenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DineInMenus_DineInMenuId",
                table: "Dishes",
                column: "DineInMenuId",
                principalTable: "DineInMenus",
                principalColumn: "DineInMenuId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
