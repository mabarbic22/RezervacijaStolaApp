using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class EditDeskTableAddNewDataInserts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 51, 2 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 52, 3 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 101, 4 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 201, 2 });

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "DeskNumber", "RoomFloorId", "WoorkToolsId" },
                values: new object[] { 6, 207, 4, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 124, 0 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 224, 0 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 98, 0 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 13, 0 });

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeskNumber", "WoorkToolsId" },
                values: new object[] { 295, 0 });
        }
    }
}
