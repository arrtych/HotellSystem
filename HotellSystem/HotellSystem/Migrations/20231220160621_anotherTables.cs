using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellSystem.Migrations
{
    /// <inheritdoc />
    public partial class anotherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonalCode",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldMaxLength: 11);

            migrationBuilder.AddColumn<double>(
                name: "Budget",
                table: "Customers",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Hotells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    HotellId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Hotells_HotellId",
                        column: x => x.HotellId,
                        principalTable: "Hotells",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    isFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    BedsAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    HotellId = table.Column<int>(type: "INTEGER", nullable: true),
                    ReservationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotells_HotellId",
                        column: x => x.HotellId,
                        principalTable: "Hotells",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HotellId",
                table: "Reservations",
                column: "HotellId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotellId",
                table: "Rooms",
                column: "HotellId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ReservationId",
                table: "Rooms",
                column: "ReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Hotells");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "PersonalCode",
                table: "Customers",
                type: "INTEGER",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
