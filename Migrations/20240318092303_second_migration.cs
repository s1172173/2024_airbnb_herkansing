using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class second_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Landlord_Image_Avatarid",
                table: "Landlord");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_Image_Imagesid",
                table: "Location");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Location_Imagesid",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Landlord_Avatarid",
                table: "Landlord");

            migrationBuilder.DropColumn(
                name: "Imagesid",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "Avatarid",
                table: "Landlord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Imagesid",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Avatarid",
                table: "Landlord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCover = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Location_Imagesid",
                table: "Location",
                column: "Imagesid");

            migrationBuilder.CreateIndex(
                name: "IX_Landlord_Avatarid",
                table: "Landlord",
                column: "Avatarid");

            migrationBuilder.AddForeignKey(
                name: "FK_Landlord_Image_Avatarid",
                table: "Landlord",
                column: "Avatarid",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Image_Imagesid",
                table: "Location",
                column: "Imagesid",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
