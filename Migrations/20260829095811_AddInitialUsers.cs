using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_DeskId",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "MailAdress", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "0993855267", "mabarbic22@gmail.com", "Marko", "Barbić" },
                    { 2, "0993456755", "nibarbic22@gmail.com", "Nikolina", "Barbić" },
                    { 3, "0912675098", "tomi12@gmail.com", "Tomislav", "Marković" },
                    { 4, "0923456123", "josip.ninic@vsite.hr", "Josip", "Ninić" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DeskId_ReservationDate",
                table: "Reservations",
                columns: new[] { "DeskId", "ReservationDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_DeskId_ReservationDate",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DeskId",
                table: "Reservations",
                column: "DeskId");
        }
    }
}
