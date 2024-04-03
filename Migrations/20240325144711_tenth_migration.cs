using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class tenth_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Description", "Features", "ImageId", "LanlordId", "NumberOfGuests", "PricePerDay", "ReservationId", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.", 4, null, null, 2, 100f, null, 1, "Lekker veel ruimte", "De Boerenhoeve", 1 },
                    { 4, "Description 4", 4, null, null, 2, 100f, null, 1, "Subtitle 4", "Location 4", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Description", "Features", "ImageId", "LanlordId", "NumberOfGuests", "PricePerDay", "ReservationId", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.", 4, null, null, 2, 100f, null, 1, "Lekker veel ruimte", "De Boerenhoeve", 1 },
                    { 2, "Description 4", 4, null, null, 2, 100f, null, 1, "Subtitle 4", "Location 2", 0 }
                });
        }
    }
}
