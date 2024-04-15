using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2024_airbnb_herkansing.Migrations
{
    /// <inheritdoc />
    public partial class init_migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ImageId",
                table: "Location");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ImageId", "Description", "IsCover", "Url" },
                values: new object[,]
                {
                    { 12, null, true, "https://images.unsplash.com/photo-1605146769289-440113cc3d00?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 13, null, false, "https://images.unsplash.com/photo-1629079448105-35ab3e5152d4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 14, null, true, "https://images.unsplash.com/photo-1602343168117-bb8ffe3e2e9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 15, null, false, "https://images.unsplash.com/photo-1501685532562-aa6846b14a0e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 16, null, true, "https://images.unsplash.com/photo-1430285561322-7808604715df?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 17, null, false, "https://images.unsplash.com/photo-1611145367596-364abefb1f9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 18, null, true, "https://images.unsplash.com/photo-1600047509358-9dc75507daeb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjR8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 19, null, false, "https://images.unsplash.com/photo-1607582544644-f1da2a004994?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 20, null, true, "https://images.unsplash.com/photo-1588012886079-baef0ac45fbd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzB8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 21, null, false, "https://images.unsplash.com/photo-1484301548518-d0e0a5db0fc8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mjl8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 22, null, true, "https://images.unsplash.com/photo-1600607688969-a5bfcd646154?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzZ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" },
                    { 23, null, false, "https://images.unsplash.com/photo-1599619351208-3e6c839d6828?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzR8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "Description", "Features", "ImageId", "LandlordId", "NumberOfGuests", "PricePerDay", "Rooms", "SubTitle", "Title", "Type" },
                values: new object[,]
                {
                    { 5, "Indulge in the vibrant city life while enjoying the comfort of this stylish urban oasis. With its modern design, top-notch amenities, and convenient location, it's the perfect choice for your city adventure.", 44, null, 3, 3, 150f, 3, "Urban luxury", "City Oasis", 0 },
                    { 6, "Experience the charm of country living in this beautiful rustic farmhouse. Surrounded by rolling hills and lush greenery, it's the perfect retreat for those seeking peace and tranquility.", 48, null, 1, 5, 80f, 2, "A taste of country living", "Rustic Farmhouse", 3 },
                    { 7, "Stay in the heart of the city in this cozy studio apartment. Enjoy easy access to restaurants, shops, and attractions, and experience the vibrant energy of the city.", 7, null, 2, 2, 60f, 1, "City center convenience", "Cozy Studio", 0 },
                    { 8, "Escape to this charming lakefront cottage and immerse yourself in the serenity of nature. Relax on the private dock, go fishing, or simply enjoy the breathtaking views of the tranquil lake.", 14, null, 3, 6, 110f, 3, "Unwind by the lake", "Lakefront Cottage", 5 },
                    { 9, "Step into this stylish and modern loft and be captivated by its industrial chic design. With its open floor plan, high ceilings, and state-of-the-art amenities, it's the perfect urban retreat.", 28, null, 1, 4, 95f, 2, "Industrial chic", "Modern Loft", 4 },
                    { 10, "Indulge in the lap of luxury in this breathtaking villa. With its lavish interiors, private pool, and impeccable service, it offers an unforgettable experience of pure elegance and opulence.", 44, null, 2, 8, 250f, 3, "Exquisite elegance", "Luxury Villa", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Location_ImageId",
                table: "Image",
                column: "ImageId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Location_ImageId",
                table: "Image");

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "Image",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ImageId",
                table: "Location",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Image_ImageId",
                table: "Location",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "ImageId");
        }
    }
}
