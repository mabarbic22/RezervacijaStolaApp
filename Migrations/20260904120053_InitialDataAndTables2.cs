using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RezervacijaStolaApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataAndTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomFloor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Floor = table.Column<string>(type: "TEXT", nullable: false),
                    FloorDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFloor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Desks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeskNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomFloorId = table.Column<int>(type: "INTEGER", nullable: false),
                    WoorkToolsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desks_RoomFloor_RoomFloorId",
                        column: x => x.RoomFloorId,
                        principalTable: "RoomFloor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReservationDate = table.Column<DateTime>(type: "date", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    DeskId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Desks_DeskId",
                        column: x => x.DeskId,
                        principalTable: "Desks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Desktop = table.Column<bool>(type: "INTEGER", nullable: false),
                    Mouse = table.Column<bool>(type: "INTEGER", nullable: false),
                    Keyboard = table.Column<bool>(type: "INTEGER", nullable: false),
                    DockingStation = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeskId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkTools_Desks_DeskId",
                        column: x => x.DeskId,
                        principalTable: "Desks",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "RoomFloor",
                columns: new[] { "Id", "Floor", "FloorDescription" },
                values: new object[,]
                {
                    { 1, "-1", "Suteren" },
                    { 2, "0", "Prizemlje" },
                    { 3, "1", "Prvi kat" },
                    { 4, "2", "Drugi kat" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "MailAdress", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "0993855267", "mabarbic22@gmail.com", "Marko", "Barbić" },
                    { 2, "0993456755", "nibirac@gmail.com", "Nikolina", "Birač" },
                    { 3, "0912675098", "tomi12@gmail.com", "Tomislav", "Marković" },
                    { 4, "0923456123", "josip.ninic@vsite.hr", "Josip", "Ninić" },
                    { 5, "092344573", "nikolanik@vsite.hr", "Nikola", "Nikolić" },
                    { 6, "0923456123", "astanic@gmail.com", "Andrej", "Stanić" },
                    { 7, "0923456723", "monijosipov@gmail.com", "Monika", "Josipović" },
                    { 8, "092788823", "juricjure@gmail.com", "Jure", "Jurić" },
                    { 9, "098157899", "tihica.glasn@gmail.com", "Tihomir", "Glasnović" }
                });

            migrationBuilder.InsertData(
                table: "Desks",
                columns: new[] { "Id", "DeskNumber", "RoomFloorId", "WoorkToolsId" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 2, 1, 0 },
                    { 3, 3, 1, 0 },
                    { 4, 4, 1, 0 },
                    { 5, 5, 1, 0 },
                    { 6, 6, 1, 0 },
                    { 7, 7, 1, 0 },
                    { 8, 8, 1, 0 },
                    { 9, 9, 2, 0 },
                    { 10, 10, 2, 0 },
                    { 11, 11, 2, 0 },
                    { 12, 12, 2, 0 },
                    { 13, 13, 2, 0 },
                    { 14, 14, 2, 0 },
                    { 15, 15, 2, 0 },
                    { 16, 16, 2, 0 },
                    { 17, 17, 2, 0 },
                    { 18, 18, 2, 0 },
                    { 19, 19, 2, 0 },
                    { 20, 20, 2, 0 },
                    { 21, 21, 3, 0 },
                    { 22, 22, 3, 0 },
                    { 23, 23, 3, 0 },
                    { 24, 24, 3, 0 },
                    { 25, 25, 3, 0 },
                    { 26, 26, 3, 0 },
                    { 27, 27, 3, 0 },
                    { 28, 28, 3, 0 },
                    { 29, 29, 3, 0 },
                    { 30, 30, 3, 0 },
                    { 31, 31, 3, 0 },
                    { 32, 32, 3, 0 },
                    { 33, 33, 4, 0 },
                    { 34, 34, 4, 0 },
                    { 35, 35, 4, 0 },
                    { 36, 36, 4, 0 },
                    { 37, 37, 4, 0 },
                    { 38, 38, 4, 0 },
                    { 39, 39, 4, 0 },
                    { 40, 40, 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "DeskId", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 4, new DateTime(2026, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 23, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 32, new DateTime(2026, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, 11, new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 8, 12, new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, 18, new DateTime(2026, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, 21, new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 11, 22, new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 12, 40, new DateTime(2026, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 13, 26, new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 14, 35, new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "WorkTools",
                columns: new[] { "Id", "DeskId", "Desktop", "DockingStation", "Keyboard", "Mouse" },
                values: new object[,]
                {
                    { 1, 1, true, false, false, true },
                    { 2, 2, false, false, false, false },
                    { 3, 3, true, true, false, true },
                    { 4, 4, true, false, true, true },
                    { 5, 5, true, false, false, true },
                    { 6, 6, false, false, false, false },
                    { 7, 7, true, true, false, true },
                    { 8, 8, true, false, true, true },
                    { 9, 9, true, false, false, true },
                    { 10, 10, false, false, false, false },
                    { 11, 11, true, true, false, true },
                    { 12, 12, true, false, true, true },
                    { 13, 13, true, false, false, true },
                    { 14, 14, false, false, false, false },
                    { 15, 15, true, true, false, true },
                    { 16, 16, true, false, true, true },
                    { 17, 17, true, false, false, true },
                    { 18, 18, false, false, false, false },
                    { 19, 19, true, true, false, true },
                    { 20, 20, true, false, true, true },
                    { 21, 21, true, false, false, true },
                    { 22, 22, false, false, false, false },
                    { 23, 23, true, true, false, true },
                    { 24, 24, true, false, true, true },
                    { 25, 25, true, false, false, true },
                    { 26, 26, false, false, false, false },
                    { 27, 27, true, true, false, true },
                    { 28, 28, true, false, true, true },
                    { 29, 29, true, false, false, true },
                    { 30, 30, false, false, false, false },
                    { 31, 31, true, true, false, true },
                    { 32, 32, true, false, true, true },
                    { 33, 33, true, false, false, true },
                    { 34, 34, false, false, false, false },
                    { 35, 35, true, true, false, true },
                    { 36, 36, true, false, true, true },
                    { 37, 37, true, false, false, true },
                    { 38, 38, false, false, false, false },
                    { 39, 39, true, true, false, true },
                    { 40, 40, true, false, true, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desks_RoomFloorId",
                table: "Desks",
                column: "RoomFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DeskId_ReservationDate",
                table: "Reservations",
                columns: new[] { "DeskId", "ReservationDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTools_DeskId",
                table: "WorkTools",
                column: "DeskId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "WorkTools");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Desks");

            migrationBuilder.DropTable(
                name: "RoomFloor");
        }
    }
}
