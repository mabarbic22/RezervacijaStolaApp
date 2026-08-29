using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialDesk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "DeskNumber", "Room" },
                values: new object[,]
                {
                    { 1, 124, "1" },
                    { 2, 224, "S11" },
                    { 3, 98, "2" },
                    { 4, 13, "7" },
                    { 5, 295, "S2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
