using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class thirdth_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Landlord",
                newName: "LandlordId");

            migrationBuilder.AddColumn<int>(
                name: "Features",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanlordId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Landlord",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Landlord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCover = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
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
                name: "IX_Landlord_ImageId",
                table: "Landlord",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_LocationId",
                table: "Landlord",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer",
                column: "ReservationId",
                unique: true,
                filter: "[ReservationId] IS NOT NULL");

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
                name: "FK_Landlord_Image_ImageId",
                table: "Landlord",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlord_Location_LocationId",
                table: "Landlord",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Landlord_LanlordId",
                table: "Location",
                column: "LanlordId",
                principalTable: "Landlord",
                principalColumn: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Reservation_ReservationId",
                table: "Location",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Reservation_ReservationId",
                table: "Customer",
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
                name: "FK_Landlord_Location_LocationId",
                table: "Landlord");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Landlord_LanlordId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Reservation_ReservationId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Reservation_ReservationId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Location_ImageId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_LanlordId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ReservationId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Landlord_ImageId",
                table: "Landlord");

            migrationBuilder.DropIndex(
                name: "IX_Landlord_LocationId",
                table: "Landlord");

            migrationBuilder.DropColumn(
                name: "Features",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LanlordId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Landlord");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Landlord");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Location",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LandlordId",
                table: "Landlord",
                newName: "Id");
        }
    }
}
