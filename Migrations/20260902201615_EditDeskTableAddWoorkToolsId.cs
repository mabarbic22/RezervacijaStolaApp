using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class EditDeskTableAddWoorkToolsId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WoorkToolsId",
                table: "Desks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 1,
                column: "WoorkToolsId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 2,
                column: "WoorkToolsId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 3,
                column: "WoorkToolsId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 4,
                column: "WoorkToolsId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Desks",
                keyColumn: "Id",
                keyValue: 5,
                column: "WoorkToolsId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WoorkToolsId",
                table: "Desks");
        }
    }
}
