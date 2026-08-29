using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDeskIdInWoorkToolsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "DeskId",
            table: "WorkTools",
            type: "int",
            nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DeskId", table: "WorkTools");
        }
    }
}
