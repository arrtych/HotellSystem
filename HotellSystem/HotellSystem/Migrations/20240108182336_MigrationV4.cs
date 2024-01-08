using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellSystem.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Hotells_HotellId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotells_HotellId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotellId",
                table: "Rooms",
                newName: "HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotellId",
                table: "Rooms",
                newName: "IX_Rooms_HotelId");

            migrationBuilder.RenameColumn(
                name: "HotellId",
                table: "Reservations",
                newName: "HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_HotellId",
                table: "Reservations",
                newName: "IX_Reservations_HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Hotells_HotelId",
                table: "Reservations",
                column: "HotelId",
                principalTable: "Hotells",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotells_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotells",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Hotells_HotelId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotells_HotelId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Rooms",
                newName: "HotellId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                newName: "IX_Rooms_HotellId");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "Reservations",
                newName: "HotellId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_HotelId",
                table: "Reservations",
                newName: "IX_Reservations_HotellId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Hotells_HotellId",
                table: "Reservations",
                column: "HotellId",
                principalTable: "Hotells",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotells_HotellId",
                table: "Rooms",
                column: "HotellId",
                principalTable: "Hotells",
                principalColumn: "Id");
        }
    }
}
