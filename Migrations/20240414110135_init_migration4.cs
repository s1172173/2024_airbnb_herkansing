using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class init_migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_ImageId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Location");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Image",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "LocationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "LocationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "LocationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "LocationId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16,
                column: "LocationId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17,
                column: "LocationId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18,
                column: "LocationId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19,
                column: "LocationId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20,
                column: "LocationId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21,
                column: "LocationId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22,
                column: "LocationId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23,
                column: "LocationId",
                value: 10);

            migrationBuilder.CreateIndex(
                name: "IX_Image_LocationId",
                table: "Image",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_LocationId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_LocationId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Location",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "ImageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "ImageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "ImageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "ImageId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5,
                column: "ImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 6,
                column: "ImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 7,
                column: "ImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 8,
                column: "ImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 9,
                column: "ImageId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 10,
                column: "ImageId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_ImageId",
                table: "Image",
                column: "ImageId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
