using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class init_migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 19, "Ren", "Traveller" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 29, "Bob", "Bouwer" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 35, "Charles ", "Xavier" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Peter ", "Parker" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 26, "Iron ", "de Man" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Brand new hotel in the heart of the city", "Just steps away from the old city center", "New City Hotel" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Detached house in a peaceful neighborhood surrounded by nature", "Enjoy the beautiful greenery in this serene environment", "Detached House" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Large old house with a stunning lakeside location", "A beautiful 19th-century house by the water", "Lakeside Villa" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Room in an apartment complex", "Double room in Barcelona", "Double Room" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Luxurious villa with a pool and spacious garden", "Perfect villa for a wonderful vacation with friends or family", "Luxury Villa Milan" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Family home for starters in Almere", "A good starter home with easy commute", "Almere Townhouse" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Villa overlooking the coast in Kijkduin", "Perfect for summer vacation in the Netherlands", "Beachside Villa" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Historic castle in the inland of France", "Stay here like royalty", "Castle in France" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Luxurious room in the most beautiful city in the Netherlands", "Explore Amsterdam and enjoy the city's offerings", "Amsterdam Apartment" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Old restored windmill with 4 rooms", "Authentic windmill used for cheese making", "Old Windmill" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 40, "John ", "Doe" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 30, "Mary ", "Bane" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 34, "Bruce ", "Spanner" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Tony ", "Spark" });

            migrationBuilder.UpdateData(
                table: "Landlord",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName" },
                values: new object[] { 25, "Harry ", "de Spotter" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Nieuw hotel in de stad", "met 1 stap in het oude centrum van de stad", "Nieuwbouw Hotel" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Vrijstaand huis met een rustige buurt en veel natuur in de omgeving", "geniet van de prachtige groene natuur in deze rustige omgeving", "Vrijstaand Huis" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Groot oud huis met prachtige ligging aan het meer", "Een prachtig huis uit de 19de eeuw aan het water", "Villa aan het water" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "kamer in apartementencomplex", "2 persoons kamer in Barcelona", "2 persoons kamer " });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "luxeuze villa met zwembad en grote tuin", "grote villa voor een prachtige vakantie met vrienden of familie", "Super villa Milaan" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Eengezinswoning voor starter in Almere", "Een goede starters woning met goed woon/werkverkeer", "Rijtjeshuis in Almere" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Villa met uitzicht over de kust in Kijkduin", "Perfect voor de zomervakantie in Nederland ", "Villa aan het strand" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Historisch kasteel in de binnenlanden van Frankrijk", "Verblijf hier als een koninklijke familie", "Kasteel in Frankrijk" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Prijzige kamer in mooiste stad van Nederland", "Verken Amsterdam en geniet van de mogelijkheden in de stad", "Appartement Amsterdam" });

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SubTitle", "Title" },
                values: new object[] { "Oude gerestaureerde molen met 4 kamers", "Authentieke Molen gebruikt voor het maken van kaas", "Oude Molen" });
        }
    }
}
