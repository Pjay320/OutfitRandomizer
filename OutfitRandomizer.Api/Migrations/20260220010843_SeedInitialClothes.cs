using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutfitRandomizer.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialClothes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "Spodnie Zwykłe", "sOliver niskie jeans" },
                    { 2, "Spodnie Zwykłe", "szare jeans" },
                    { 3, "Spodnie Zwykłe", "czarne jeans" },
                    { 4, "Spodnie Zwykłe", "kratka" },
                    { 11, "Sukienki", "polar ruda" },
                    { 12, "Sukienki", "prosta czarna" },
                    { 13, "Sukienki", "kwiaty ruda" },
                    { 14, "Sukienki", "paski czarno-biała" },
                    { 31, "Bluzki (Luźniejsze)", "my little pony" },
                    { 32, "Bluzki (Luźniejsze)", "długa czarna" },
                    { 33, "Bluzki (Luźniejsze)", "kuromi czarna" },
                    { 51, "Bluzy", "krótka zielona" },
                    { 52, "Bluzy", "hollister żółta" },
                    { 53, "Bluzy", "sweterek miękki biała" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 53);
        }
    }
}
