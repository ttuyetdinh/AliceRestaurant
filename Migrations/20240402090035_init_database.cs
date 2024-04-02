using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class init_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryCategories",
                columns: table => new
                {
                    DeliveryCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCategories", x => x.DeliveryCategoryId);
                    table.ForeignKey(
                        name: "FK_DeliveryCategories_DeliveryCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "DeliveryCategories",
                        principalColumn: "DeliveryCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "DineInCategories",
                columns: table => new
                {
                    DineInCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInCategories", x => x.DineInCategoryId);
                    table.ForeignKey(
                        name: "FK_DineInCategories_DineInCategories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "DineInCategories",
                        principalColumn: "DineInCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DineInCategoryId = table.Column<int>(type: "int", nullable: false),
                    DeliveryCategoryId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    DishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KoreanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_Dishes_DeliveryCategories_DeliveryCategoryId",
                        column: x => x.DeliveryCategoryId,
                        principalTable: "DeliveryCategories",
                        principalColumn: "DeliveryCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dishes_DineInCategories_DineInCategoryId",
                        column: x => x.DineInCategoryId,
                        principalTable: "DineInCategories",
                        principalColumn: "DineInCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantDishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantDishes", x => new { x.DishId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantDishes_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantDishes_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCategories_ParentCategoryId",
                table: "DeliveryCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DineInCategories_ParentCategoryId",
                table: "DineInCategories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DeliveryCategoryId",
                table: "Dishes",
                column: "DeliveryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DineInCategoryId",
                table: "Dishes",
                column: "DineInCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDishes_RestaurantId",
                table: "RestaurantDishes",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantDishes");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "DeliveryCategories");

            migrationBuilder.DropTable(
                name: "DineInCategories");
        }
    }
}
