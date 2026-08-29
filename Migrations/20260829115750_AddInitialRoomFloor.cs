using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialRoomFloor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomFloor",
                columns: new[] { "Id", "Floor", "FloorDescription", "FloorShort" },
                values: new object[,]
                {
                    { 1, "-1", "Suteren", "S" },
                    { 2, "0", "Prizemlje", "P" },
                    { 3, "1", "Prvi kat", "K1" },
                    { 4, "2", "Drugi kat", "K2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomFloor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomFloor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomFloor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomFloor",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
