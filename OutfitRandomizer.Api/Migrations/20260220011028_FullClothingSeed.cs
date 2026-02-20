using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OutfitRandomizer.Api.Migrations
{
    /// <inheritdoc />
    public partial class FullClothingSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "szare jeans niskie luźne");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Legginsy", "ciasne" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Spodnie Dresowe", "beżowe" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Spodnie Dresowe", "różowe" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Spodnie Dresowe", "czarne" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "pastelowa kolorowa" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "japońska pomarańczowa" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "obcisła złote ramiączka ruda" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "gra dziewczynka czarna" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "ramiączka szara" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "koszula kwiaty zielona" });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 5, "Spodnie Zwykłe", "kratka" },
                    { 6, "Spodnie Zwykłe", "Ciasne jeans niebieskie" },
                    { 7, "Spodnie Zwykłe", "niebieskie jeans" },
                    { 8, "Spodnie Zwykłe", "bigstar niskie" },
                    { 9, "Legginsy", "śliskie" },
                    { 10, "Legginsy", "górskie" },
                    { 15, "Spodnie Dresowe", "brązowe" },
                    { 16, "Spódnice", "plisowana czarna" },
                    { 17, "Spódnice", "gotycka czarna" },
                    { 18, "Spódnice", "prosta różowa" },
                    { 19, "Sukienki", "polar ruda" },
                    { 20, "Sukienki", "prosta czarna" },
                    { 21, "Sukienki", "kwiaty ruda" },
                    { 22, "Sukienki", "paski czarno-biała" },
                    { 23, "Sukienki", "długa niebieska" },
                    { 24, "Sukienki", "mini obcisła czarna" },
                    { 25, "Sukienki", "kwiatowa ramiączka kolorowa" },
                    { 26, "Sukienki", "sztruks czarna" },
                    { 27, "Sukienki", "sztruks ruda" },
                    { 28, "Sukienki", "kropki zielona" },
                    { 29, "Sukienki", "paski stara letnia czarno-biała" },
                    { 30, "Sukienki", "kropki czarna" },
                    { 34, "Sukienki", "uczennica krata" },
                    { 35, "Sukienki", "miękka długi rękaw ruda" },
                    { 36, "Bluzki (Luźniejsze)", "my little pony" },
                    { 37, "Bluzki (Luźniejsze)", "długa czarna" },
                    { 38, "Bluzki (Luźniejsze)", "biała twarz czarna" },
                    { 39, "Bluzki (Luźniejsze)", "ramiączka czarna" },
                    { 40, "Bluzki (Luźniejsze)", "jedwab wiśniowa" },
                    { 41, "Bluzki (Luźniejsze)", "jedwab różowa" },
                    { 42, "Bluzki (Luźniejsze)", "paski niebieska" },
                    { 43, "Bluzki (Luźniejsze)", "kuromi czarna" },
                    { 44, "Bluzki (Luźniejsze)", "napis słońce biała" },
                    { 45, "Bluzki (Luźniejsze)", "jedwab ramiączka prosta czarna" },
                    { 46, "Bluzki (Luźniejsze)", "różowa twarz czarna" },
                    { 47, "Bluzki (Luźniejsze)", "jedwab falbanki czarna" },
                    { 48, "Bluzki (Luźniejsze)", "ramiączka stara czarna" },
                    { 49, "Bluzki (Luźniejsze)", "fioletowa twarz biała" },
                    { 50, "Bluzki (Luźniejsze)", "barbie biała" },
                    { 54, "Bluzki (Luźniejsze)", "koszula pomarańczowa" },
                    { 55, "Bluzki (Luźniejsze)", "szkielety dziewczynka czarna" },
                    { 56, "Bluzki (Luźniejsze)", "zioło dziewczynka czarna" },
                    { 57, "Bluzki (Luźniejsze)", "ramiączka sztruks szara" },
                    { 58, "Bluzki (Luźniejsze)", "hollister biała" },
                    { 59, "Bluzki (Luźniejsze)", "liście biała" },
                    { 60, "Bluzki (Obcisłe)", "kuromi fioletowa" },
                    { 61, "Bluzki (Obcisłe)", "Bambi różowa" },
                    { 62, "Bluzki (Obcisłe)", "miś różowa" },
                    { 63, "Bluzki (Obcisłe)", "cienka beżowa" },
                    { 64, "Bluzki (Obcisłe)", "długa czarna" },
                    { 65, "Bluzki (Obcisłe)", "kratka czarno-biała" },
                    { 66, "Bluzki (Obcisłe)", "króliczek różowa" },
                    { 67, "Bluzki (Obcisłe)", "diamenciki czarna" },
                    { 68, "Bluzki (Obcisłe)", "winx różowa" },
                    { 69, "Bluzki (Obcisłe)", "dziurawa beżowa" },
                    { 70, "Bluzki (Obcisłe)", "paski pomarańczowo-szara" },
                    { 71, "Bluzki (Obcisłe)", "sztruks czarna" },
                    { 72, "Bluzki (Obcisłe)", "długa niebieska" },
                    { 73, "Bluzy", "krótka zielona" },
                    { 74, "Bluzy", "krótka czarna" },
                    { 75, "Bluzy", "prosta czarna" },
                    { 76, "Bluzy", "hollister żółta" },
                    { 77, "Bluzy", "barbie biała" },
                    { 78, "Bluzy", "prosta pomarańczowa" },
                    { 79, "Bluzy", "golf biały" },
                    { 80, "Bluzy", "sportowa szara" },
                    { 81, "Bluzy", "róże czarna" },
                    { 82, "Bluzy", "napisy brązowa" },
                    { 83, "Bluzy", "prosta szara" },
                    { 84, "Bluzy", "kws szara" },
                    { 85, "Bluzy", "góry zielona" },
                    { 86, "Bluzy", "komplet beżowa" },
                    { 87, "Bluzy", "sweterek miękki biała" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "kratka");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "polar ruda" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "prosta czarna" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "kwiaty ruda" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sukienki", "paski czarno-biała" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "my little pony" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "długa czarna" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzki (Luźniejsze)", "kuromi czarna" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzy", "krótka zielona" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzy", "hollister żółta" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Bluzy", "sweterek miękki biała" });
        }
    }
}
