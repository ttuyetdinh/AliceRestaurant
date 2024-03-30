using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class update_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryMenu_DeliveryMenu_ParentMenuId",
                table: "DeliveryMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_DineInMenu_DineInMenu_ParentMenuId",
                table: "DineInMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryMenu_DeliveryMenuId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInMenu_DineInMenuId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantDish_Dishes_DishId",
                table: "RestaurantDish");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantDish_Restaurant_RestaurantId",
                table: "RestaurantDish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantDish",
                table: "RestaurantDish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DineInMenu",
                table: "DineInMenu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryMenu",
                table: "DeliveryMenu");

            migrationBuilder.RenameTable(
                name: "RestaurantDish",
                newName: "RestaurantDishes");

            migrationBuilder.RenameTable(
                name: "Restaurant",
                newName: "Restaurants");

            migrationBuilder.RenameTable(
                name: "DineInMenu",
                newName: "DineInMenus");

            migrationBuilder.RenameTable(
                name: "DeliveryMenu",
                newName: "DeliveryMenus");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantDish_RestaurantId",
                table: "RestaurantDishes",
                newName: "IX_RestaurantDishes_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_DineInMenu_ParentMenuId",
                table: "DineInMenus",
                newName: "IX_DineInMenus_ParentMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryMenu_ParentMenuId",
                table: "DeliveryMenus",
                newName: "IX_DeliveryMenus_ParentMenuId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "RestaurantDishes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "RestaurantDishes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Restaurants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Restaurants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "DineInMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "DineInMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "DeliveryMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "DeliveryMenus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantDishes",
                table: "RestaurantDishes",
                columns: new[] { "DishId", "RestaurantId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants",
                column: "RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DineInMenus",
                table: "DineInMenus",
                column: "DineInMenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryMenus",
                table: "DeliveryMenus",
                column: "DeliveryMenuId");

            migrationBuilder.UpdateData(
                table: "DeliveryMenus",
                keyColumn: "DeliveryMenuId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6704), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "DeliveryMenus",
                keyColumn: "DeliveryMenuId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "DeliveryMenus",
                keyColumn: "DeliveryMenuId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "DeliveryMenus",
                keyColumn: "DeliveryMenuId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "DeliveryMenus",
                keyColumn: "DeliveryMenuId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "DineInMenus",
                keyColumn: "DineInMenuId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "DineInMenus",
                keyColumn: "DineInMenuId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "DineInMenus",
                keyColumn: "DineInMenuId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "DineInMenus",
                keyColumn: "DineInMenuId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "DineInMenus",
                keyColumn: "DineInMenuId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastUpdated" },
                values: new object[] { new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 3, 30, 20, 55, 36, 875, DateTimeKind.Local).AddTicks(6463) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryMenus_DeliveryMenus_ParentMenuId",
                table: "DeliveryMenus",
                column: "ParentMenuId",
                principalTable: "DeliveryMenus",
                principalColumn: "DeliveryMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_DineInMenus_DineInMenus_ParentMenuId",
                table: "DineInMenus",
                column: "ParentMenuId",
                principalTable: "DineInMenus",
                principalColumn: "DineInMenuId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantDishes_Dishes_DishId",
                table: "RestaurantDishes",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantDishes_Restaurants_RestaurantId",
                table: "RestaurantDishes",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryMenus_DeliveryMenus_ParentMenuId",
                table: "DeliveryMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_DineInMenus_DineInMenus_ParentMenuId",
                table: "DineInMenus");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DeliveryMenus_DeliveryMenuId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_DineInMenus_DineInMenuId",
                table: "Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantDishes_Dishes_DishId",
                table: "RestaurantDishes");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantDishes_Restaurants_RestaurantId",
                table: "RestaurantDishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantDishes",
                table: "RestaurantDishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DineInMenus",
                table: "DineInMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryMenus",
                table: "DeliveryMenus");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RestaurantDishes");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "RestaurantDishes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DineInMenus");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "DineInMenus");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "DeliveryMenus");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "DeliveryMenus");

            migrationBuilder.RenameTable(
                name: "Restaurants",
                newName: "Restaurant");

            migrationBuilder.RenameTable(
                name: "RestaurantDishes",
                newName: "RestaurantDish");

            migrationBuilder.RenameTable(
                name: "DineInMenus",
                newName: "DineInMenu");

            migrationBuilder.RenameTable(
                name: "DeliveryMenus",
                newName: "DeliveryMenu");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantDishes_RestaurantId",
                table: "RestaurantDish",
                newName: "IX_RestaurantDish_RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_DineInMenus_ParentMenuId",
                table: "DineInMenu",
                newName: "IX_DineInMenu_ParentMenuId");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryMenus_ParentMenuId",
                table: "DeliveryMenu",
                newName: "IX_DeliveryMenu_ParentMenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant",
                column: "RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantDish",
                table: "RestaurantDish",
                columns: new[] { "DishId", "RestaurantId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DineInMenu",
                table: "DineInMenu",
                column: "DineInMenuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryMenu",
                table: "DeliveryMenu",
                column: "DeliveryMenuId");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9763), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastUpdated", "SellingDate" },
                values: new object[] { new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 3, 30, 19, 58, 17, 960, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryMenu_DeliveryMenu_ParentMenuId",
                table: "DeliveryMenu",
                column: "ParentMenuId",
                principalTable: "DeliveryMenu",
                principalColumn: "DeliveryMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_DineInMenu_DineInMenu_ParentMenuId",
                table: "DineInMenu",
                column: "ParentMenuId",
                principalTable: "DineInMenu",
                principalColumn: "DineInMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DeliveryMenu_DeliveryMenuId",
                table: "Dishes",
                column: "DeliveryMenuId",
                principalTable: "DeliveryMenu",
                principalColumn: "DeliveryMenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_DineInMenu_DineInMenuId",
                table: "Dishes",
                column: "DineInMenuId",
                principalTable: "DineInMenu",
                principalColumn: "DineInMenuId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantDish_Dishes_DishId",
                table: "RestaurantDish",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "DishId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantDish_Restaurant_RestaurantId",
                table: "RestaurantDish",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
