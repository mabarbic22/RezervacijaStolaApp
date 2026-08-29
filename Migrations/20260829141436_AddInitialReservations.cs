using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DeskId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 4, new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, 3, new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 1, new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 4, new DateTime(2026, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, 4, new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, 3, new DateTime(2026, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, 2, new DateTime(2026, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 5, new DateTime(2026, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, 5, new DateTime(2026, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
