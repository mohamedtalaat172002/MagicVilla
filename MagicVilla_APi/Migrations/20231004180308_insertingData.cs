using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_APi.Migrations
{
    /// <inheritdoc />
    public partial class insertingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "CreatedDate", "Description", "OwnerName", "StreetName", "UpdatedDate", "area", "city", "imageUrl", "numOFrooms", "price", "villaNum" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luxury beachfront villa with stunning ocean views", "Emily Johnson", "Ocean Drive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.25, "Miami", "https://example.com/villa1-image.jpg", 6, 2500000.0, 5678 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modern villa with a rooftop terrace and panoramic city views", "Michael Anderson", "Park Avenue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 280.5, "New York", "https://example.com/villa2-image.jpg", 4, 1800000.0, 2468 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elegant villa surrounded by lush green gardens", "Sophia Lee", "Kensington High Street", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.75, "London", "https://example.com/villa3-image.jpg", 7, 2200000.0, 1357 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mediterranean-style villa with a private courtyard and fountain", "Benjamin Martinez", "Passeig de Gràcia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 320.0, "Barcelona", "https://example.com/villa4-image.jpg", 5, 1950000.0, 9876 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic countryside villa with panoramic mountain views", "Olivia Wilson", "Rue du Rhône", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600.79999999999995, "Geneva", "https://example.com/villa5-image.jpg", 8, 3400000.0, 3691 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contemporary villa with a private infinity pool overlooking the ocean", "Daniel Thompson", "Bondi Road", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450.30000000000001, "Sydney", "https://example.com/villa6-image.jpg", 6, 2700000.0, 8023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
