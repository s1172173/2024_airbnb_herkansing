using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class init_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCover = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Landlord",
                columns: table => new
                {
                    LandlordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AvatarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.LandlordId);
                    table.ForeignKey(
                        name: "FK_Landlord_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "ImageId");
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<int>(type: "int", nullable: true),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    PricePerDay = table.Column<float>(type: "real", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_Location_Landlord_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlord",
                        principalColumn: "LandlordId");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Reservation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe" },
                    { 2, "jane.doe@example.com", "Jane", "Doe" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ImageId", "Description", "IsCover", "Url" },
                values: new object[,]
                {
                    { 1, null, true, "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg" },
                    { 2, null, false, "https://www.adobe.com/nl/express/create/media_1bcd514348a568faed99e65f5249895e38b06c947.jpeg?width=400&format=jpeg&optimize=medium" },
                    { 3, null, true, "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg" },
                    { 4, null, false, "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg" },
                    { 5, null, false, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MaisonCausapscal.JPG/640px-MaisonCausapscal.JPG" },
                    { 6, null, false, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Ljungris_July_2013.jpg/640px-Ljungris_July_2013.jpg" },
                    { 7, null, false, "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8cmFuZG9tJTIwcGVyc29ufGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 8, null, true, "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 9, null, false, "https://images.unsplash.com/photo-1502005097973-6a7082348e28?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60" },
                    { 10, null, true, "https://images.unsplash.com/photo-1600047509807-ba8f99d2cdde?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 11, null, false, "https://images.unsplash.com/photo-1591247378418-c77f1532d2f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "LandlordId", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 33, 4, "Peter-Jan", "Balkenende" },
                    { 2, 20, 2, "Jan", "de Man" },
                    { 3, 25, 7, "Sandra", "Vries" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Description", "Features", "ImageId", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.", 4, 1, 1, 4, 75f, 2, "Lekker veel ruimte", "De Boerenhoeve", 0 },
                    { 2, "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.", 20, 2, 2, 6, 100f, 3, "Te gek uitzicht", "Frankie's Penthouse", 1 },
                    { 3, "Experience the ultimate beach vacation in this stunning seaside getaway. Enjoy breathtaking ocean views, luxurious amenities, and direct access to the beach.", 33, 3, 1, 2, 90f, 1, "Relax by the beach", "Seaside Getaway", 0 },
                    { 4, "Surrounded by majestic mountains, this cozy retreat offers a peaceful and idyllic setting. Explore hiking trails, enjoy outdoor activities, or simply relax in the comfort of your mountain getaway.", 16, 4, 3, 4, 120f, 2, "Escape to nature", "Mountain Retreat", 1 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 0.1f, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0f, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 0.2f, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, 0.15f, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ImageId",
                table: "Location",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LandlordId",
                table: "Location",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_LocationId",
                table: "Reservation",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Landlord");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
