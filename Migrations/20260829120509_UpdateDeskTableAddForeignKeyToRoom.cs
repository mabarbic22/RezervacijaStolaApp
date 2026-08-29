using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeskTableAddForeignKeyToRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Room",
                table: "Desks");

            migrationBuilder.AddColumn<int>(
                name: "RoomFloorId",
                table: "Desks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomFloorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomFloorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomFloorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomFloorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoomFloorId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomFloorId",
                table: "Desks");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Desks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Room",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Room",
                value: "S11");

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Room",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Room",
                value: "7");

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Room",
                value: "S2");
        }
    }
}
