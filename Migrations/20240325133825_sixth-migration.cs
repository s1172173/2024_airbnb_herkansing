using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class sixthmigration : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Customer_ReservationId",
                table: "Customer");

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
    }
}
