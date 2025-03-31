using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "Description", "EnglishName", "Family", "HarvestTime", "Image", "LatinName", "MoveTime", "PlantingDate" },
                values: new object[,]
                {
                    { 1, "A red, edible fruit often used in salads and cooking.", "Tomato", "Solanaceae", new DateOnly(2024, 7, 15), "tomato.jpg", "Solanum lycopersicum", new DateOnly(2024, 5, 1), new DateOnly(2024, 3, 1) },
                    { 2, "A root vegetable, usually orange in color.", "Carrot", "Apiaceae", new DateOnly(2024, 8, 30), "carrot.jpg", "Daucus carota", new DateOnly(2024, 5, 20), new DateOnly(2024, 4, 10) },
                    { 3, "A leafy green vegetable often used in salads.", "Lettuce", "Asteraceae", new DateOnly(2024, 5, 10), "lettuce.jpg", "Lactuca sativa", new DateOnly(2024, 3, 20), new DateOnly(2024, 2, 15) },
                    { 4, "A fragrant herb used in cooking, especially in Italian cuisine.", "Basil", "Lamiaceae", new DateOnly(2025, 4, 15), "basil.jpg", "Ocimum basilicum", new DateOnly(2025, 3, 20), new DateOnly(2025, 3, 5) },
                    { 5, "A sweet red fruit often eaten fresh or used in desserts.", "Strawberry", "Rosaceae", new DateOnly(2025, 4, 30), "strawberry.jpg", "Fragaria × ananassa", new DateOnly(2025, 3, 25), new DateOnly(2025, 3, 10) },
                    { 6, "A leafy green vegetable rich in iron and vitamins.", "Spinach", "Amaranthaceae", new DateOnly(2025, 5, 10), "spinach.jpg", "Spinacia oleracea", new DateOnly(2025, 4, 15), new DateOnly(2025, 4, 1) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 6);
        }
    }
}
