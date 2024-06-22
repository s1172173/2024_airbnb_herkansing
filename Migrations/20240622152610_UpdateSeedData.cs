using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCover = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Landlord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    AvatarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Landlord_Image_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Image",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfGuests = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PricePerDay = table.Column<float>(type: "real", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Landlord_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "Alice", "Wonderland" },
                    { 2, "bob@example.com", "Bob", "Builder" },
                    { 3, "charlie@example.com", "Charlie", "Chocolate" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 1, false, null, "https://images.pexels.com/photos/4626807/pexels-photo-4626807.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 2, false, null, "https://images.pexels.com/photos/4588043/pexels-photo-4588043.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 3, false, null, "https://images.pexels.com/photos/3789871/pexels-photo-3789871.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 4, false, null, "https://images.pexels.com/photos/3687061/pexels-photo-3687061.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 5, false, null, "https://images.pexels.com/photos/4099585/pexels-photo-4099585.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "Id", "Age", "AvatarId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 30, 1, "John", "Doe" },
                    { 2, 25, 2, "Jane", "Smith" },
                    { 3, 40, 3, "Jim", "Bean" },
                    { 4, 35, 4, "Jill", "Hill" },
                    { 5, 28, 5, "Jack", "Black" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Description", "Features", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Modern apartment in the city center", 12, 1, 4, 80f, 2, "Close to all amenities", "City Center Apartment", 0 },
                    { 2, "Cozy cottage in the countryside", 34, 2, 6, 120f, 3, "Peaceful and quiet", "Countryside Cottage", 1 },
                    { 3, "Beachfront villa with stunning views", 20, 3, 8, 250f, 4, "Steps from the beach", "Beachfront Villa", 5 },
                    { 4, "Single room in a shared house", 8, 4, 2, 40f, 1, "Affordable and convenient", "Shared House Room", 3 },
                    { 5, "Luxury mansion with private pool", 28, 5, 10, 450f, 5, "Exclusive and luxurious", "Luxury Mansion", 5 },
                    { 6, "Charming townhouse in a historic district", 4, 1, 4, 90f, 2, "Experience the history", "Historic Townhouse", 5 },
                    { 7, "Modern chalet with mountain views", 10, 2, 6, 200f, 3, "Perfect for a getaway", "Mountain Chalet", 2 },
                    { 8, "Cozy studio in the heart of the city", 4, 3, 2, 60f, 1, "Ideal for solo travelers", "City Studio", 0 },
                    { 9, "Spacious house with garden", 34, 4, 8, 150f, 4, "Perfect for families", "Family House", 5 },
                    { 10, "Historic castle with modern amenities", 28, 5, 12, 350f, 6, "Live like royalty", "Modern Castle", 5 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "IsCover", "LocationId", "Url" },
                values: new object[,]
                {
                    { 6, true, 1, "https://images.pexels.com/photos/2998307/pexels-photo-2998307.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 7, true, 2, "https://images.pexels.com/photos/1459493/pexels-photo-1459493.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 8, true, 3, "https://images.pexels.com/photos/279746/pexels-photo-279746.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 9, true, 4, "https://images.pexels.com/photos/2102587/pexels-photo-2102587.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 10, true, 5, "https://images.pexels.com/photos/2118125/pexels-photo-2118125.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 11, true, 6, "https://images.pexels.com/photos/4325436/pexels-photo-4325436.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 12, true, 7, "https://images.pexels.com/photos/2433061/pexels-photo-2433061.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 13, true, 8, "https://images.pexels.com/photos/1759895/pexels-photo-1759895.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 14, true, 9, "https://images.pexels.com/photos/1282315/pexels-photo-1282315.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 15, true, 10, "https://images.pexels.com/photos/205827/pexels-photo-205827.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 16, false, 1, "https://images.pexels.com/photos/2050994/pexels-photo-2050994.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 17, false, 1, "https://images.pexels.com/photos/2179213/pexels-photo-2179213.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 18, false, 5, "https://images.pexels.com/photos/2194262/pexels-photo-2194262.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 19, false, 5, "https://images.pexels.com/photos/3117091/pexels-photo-3117091.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 20, false, 9, "https://images.pexels.com/photos/39866/pexels-photo-39866.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 21, false, 6, "https://images.pexels.com/photos/235647/pexels-photo-235647.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 22, false, 8, "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                    { 23, false, 10, "https://images.pexels.com/photos/1961457/pexels-photo-1961457.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 0.1f, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0f, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0.2f, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 0.15f, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 0.1f, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_AvatarId",
                table: "Landlord",
                column: "AvatarId",
                unique: true,
                filter: "[AvatarId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

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
