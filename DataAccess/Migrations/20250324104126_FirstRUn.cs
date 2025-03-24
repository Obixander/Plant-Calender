using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstRUn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MoveTime = table.Column<DateOnly>(type: "date", nullable: false),
                    HarvestTime = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "Plantplots",
                columns: table => new
                {
                    PlantPlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    LastWatered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastFertilized = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantplots", x => x.PlantPlotId);
                    table.ForeignKey(
                        name: "FK_Plantplots_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantPlotHistories",
                columns: table => new
                {
                    PlantPlotHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantPlotId = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantPlotHistories", x => x.PlantPlotHistoryId);
                    table.ForeignKey(
                        name: "FK_PlantPlotHistories_Plantplots_PlantPlotId",
                        column: x => x.PlantPlotId,
                        principalTable: "Plantplots",
                        principalColumn: "PlantPlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlantPlotHistories_PlantPlotId",
                table: "PlantPlotHistories",
                column: "PlantPlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantplots_PlantId",
                table: "Plantplots",
                column: "PlantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlantPlotHistories");

            migrationBuilder.DropTable(
                name: "Plantplots");

            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
