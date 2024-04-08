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
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Landlord", x => x.LandlordId);
                    table.ForeignKey(
                        name: "FK_Landlord_Image_ImageId",
                        column: x => x.ImageId,
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
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    LanlordId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Location_Landlord_LanlordId",
                        column: x => x.LanlordId,
                        principalTable: "Landlord",
                        principalColumn: "LandlordId");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "LocationV2",
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
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    LanlordId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationV2", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_LocationV2_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_LocationV2_Landlord_LanlordId",
                        column: x => x.LanlordId,
                        principalTable: "Landlord",
                        principalColumn: "LandlordId");
                    table.ForeignKey(
                        name: "FK_LocationV2_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "ReservationId");
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "jamesjamerson@gmail.com", "James", "Jamerson" },
                    { 2, "emilyboberson@gmail.com", "Emily", "Boberson" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ImageId", "Description", "IsCover", "Url" },
                values: new object[,]
                {
                    { 1, "Avatar of Landlord 1", true, "avatar_landlord_2.jpg" },
                    { 2, "Avatar of Landlord 2", true, "avatar_landlord_2.jpg" },
                    { 3, "Image of location 1", true, "image_location_1.jpg" },
                    { 4, "Image of location 2", true, "image_location_2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Landlord",
                columns: new[] { "LandlordId", "Age", "FirstName", "ImageId", "LastName", "LocationId" },
                values: new object[,]
                {
                    { 1, 35, "Landlord 1", null, "Lastname 1", null },
                    { 2, 45, "Landlord 2", null, "Lastname 2", null }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Description", "Features", "ImageId", "LanlordId", "NumberOfGuests", "PricePerDay", "ReservationId", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.", 4, null, null, 2, 100f, null, 1, "Lekker veel ruimte", "De Boerenhoeve", 1 },
                    { 4, "Description 4", 4, null, null, 2, 100f, null, 1, "Subtitle 4", "Location 4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, 0f, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 2, 0f, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), null, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_ImageId",
                table: "Landlord",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_LocationId",
                table: "Landlord",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ImageId",
                table: "Location",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LanlordId",
                table: "Location",
                column: "LanlordId",
                unique: true,
                filter: "[LanlordId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ReservationId",
                table: "Location",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationV2_ImageId",
                table: "LocationV2",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationV2_LanlordId",
                table: "LocationV2",
                column: "LanlordId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationV2_ReservationId",
                table: "LocationV2",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_LocationId",
                table: "Reservation",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlord_Location_LocationId",
                table: "Landlord",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Reservation_ReservationId",
                table: "Location",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlord_Image_ImageId",
                table: "Landlord");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Landlord_Location_LocationId",
                table: "Landlord");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Location_LocationId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "LocationV2");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Landlord");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
