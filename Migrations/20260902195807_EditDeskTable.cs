using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class EditDeskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkTools_DeskId",
                table: "WorkTools");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTools_DeskId",
                table: "WorkTools",
                column: "DeskId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desks_RoomFloorId",
                table: "Desks",
                column: "RoomFloorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desks_RoomFloor_RoomFloorId",
                table: "Desks",
                column: "RoomFloorId",
                principalTable: "RoomFloor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desks_RoomFloor_RoomFloorId",
                table: "Desks");

            migrationBuilder.DropIndex(
                name: "IX_WorkTools_DeskId",
                table: "WorkTools");

            migrationBuilder.DropIndex(
                name: "IX_Desks_RoomFloorId",
                table: "Desks");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTools_DeskId",
                table: "WorkTools",
                column: "DeskId");
        }
    }
}
