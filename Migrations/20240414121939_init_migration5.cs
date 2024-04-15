using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class init_migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LandlordId",
                table: "Image",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 2 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "LandlordId", "LocationId" },
                values: new object[] { null, 4 });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22,
                column: "LandlordId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23,
                column: "LandlordId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Image_LandlordId",
                table: "Image",
                column: "LandlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Landlord_LandlordId",
                table: "Image",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "LandlordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Landlord_LandlordId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_LandlordId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Image");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "LocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "LocationId",
                value: null);
        }
    }
}
