using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialWorkTools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkTools",
                columns: new[] { "Id", "DeskId", "Desktop", "DockingStation", "Keyboard", "Mouse" },
                values: new object[,]
                {
                    { 1, 1, true, false, false, true },
                    { 2, 2, false, false, false, false },
                    { 3, 3, true, true, false, true },
                    { 4, 4, true, false, true, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkTools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkTools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkTools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkTools",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
