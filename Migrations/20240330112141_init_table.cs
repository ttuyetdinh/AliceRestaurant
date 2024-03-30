using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliceRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class init_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryMenu",
                columns: table => new
                {
                    DeliveryMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMenu", x => x.DeliveryMenuId);
                    table.ForeignKey(
                        name: "FK_DeliveryMenu_DeliveryMenu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DeliveryMenu",
                        principalColumn: "DeliveryMenuId");
                });

            migrationBuilder.CreateTable(
                name: "DineInMenu",
                columns: table => new
                {
                    DineInMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInMenu", x => x.DineInMenuId);
                    table.ForeignKey(
                        name: "FK_DineInMenu_DineInMenu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "DineInMenu",
                        principalColumn: "DineInMenuId");
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DineInMenuId = table.Column<int>(type: "int", nullable: false),
                    DeliveryMenuId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Dishes_DeliveryMenu_DeliveryMenuId",
                        column: x => x.DeliveryMenuId,
                        principalTable: "DeliveryMenu",
                        principalColumn: "DeliveryMenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dishes_DineInMenu_DineInMenuId",
                        column: x => x.DineInMenuId,
                        principalTable: "DineInMenu",
                        principalColumn: "DineInMenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMenu_ParentMenuId",
                table: "DeliveryMenu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_DineInMenu_ParentMenuId",
                table: "DineInMenu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DeliveryMenuId",
                table: "Dishes",
                column: "DeliveryMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DineInMenuId",
                table: "Dishes",
                column: "DineInMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "DeliveryMenu");

            migrationBuilder.DropTable(
                name: "DineInMenu");
        }
    }
}
