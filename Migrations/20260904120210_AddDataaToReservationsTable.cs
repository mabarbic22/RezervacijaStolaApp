using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDataaToReservationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DeskId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 15, 7, new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, 33, new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, 12, new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 18, 4, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 19, 9, new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, 24, new DateTime(2026, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
