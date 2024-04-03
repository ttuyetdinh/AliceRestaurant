using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class seed_dropdown_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Dishes");

            migrationBuilder.CreateTable(
                name: "Dropdown",
                columns: table => new
                {
                    DropdownId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Module = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dropdown", x => x.DropdownId);
                });

            migrationBuilder.InsertData(
                table: "Dropdown",
                columns: new[] { "DropdownId", "Description", "Module", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { 1, "A core dish in Dine Menu", "DineIn", "Core", "DishType", "Core" },
                    { 2, "A seasonal dish in Dine Menu", "DineIn", "Seasonal", "DishType", "Seasonal" },
                    { 3, "A core dish in Dine Menu", "Delivery", "Core", "DishType", "Core" },
                    { 4, "A seasonal dish in Dine Menu", "Delivery", "Seasonal", "DishType", "Seasonal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dropdown");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
