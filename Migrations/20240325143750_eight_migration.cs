using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class eight_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "ReservationId" },
                values: new object[,]
                {
                    { 1, "jamesjamerson@gmail.com", "James", "Jamerson", null },
                    { 2, "emilyboberson@gmail.com", "Emily", "Boberson", null }
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
                table: "Reservation",
                columns: new[] { "ReservationId", "CustomerId", "Discount", "EndDate", "LocationId", "StartDate" },
                values: new object[,]
                {
                    { 1, null, 0f, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, null, 0f, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local), null, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer",
                column: "ReservationId",
                unique: true,
                filter: "[ReservationId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer",
                column: "ReservationId");
        }
    }
}
