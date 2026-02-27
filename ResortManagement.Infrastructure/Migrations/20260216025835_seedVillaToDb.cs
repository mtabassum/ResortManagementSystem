using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ResortManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make yourself at home in these royal suites. Private balconies offer stunning views. Each room features a king-sized bed, lounge seating, walk-in closets, air conditioning and full-size bathrooms with double sinks, walk-in shower and tub. Rooms come fully equipped with state-of-the-art amenities including an LCD flat screen smart TV, USB ports, Keurig Coffee Brewer, mini-fridge and Wi-Fi. Available with pool or resort views.", "https://placehold.co/600x400", "Suites", 4, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make yourself at home in these premium villas. Each unit has it’s own unique decor and amenities, featuring an inviting living area with a gas-burning fireplace as well as excellent lighting and a rustic feel. Cook up a meal for family and friends in the well-equipped kitchen. Enjoy a glass of wine on the balcony while enjoying pool views. Complimentary wireless internet means you can bring all your favorite devices.", "https://placehold.co/600x401", "Premium Pool Villa", 4, 300.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Make yourself at home in these luxury villas. Each unit has it’s own unique decor and amenities, featuring an inviting living area with a gas-burning fireplace as well as excellent lighting and a rustic feel. Cook up a meal for family and friends in the well-equipped kitchen. Enjoy a glass of wine on the balcony while enjoying pool views. Complimentary wireless internet means you can bring all your favorite devices.", "https://placehold.co/600x402", "Luxury Pool Villa", 6, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
