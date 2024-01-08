using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellSystem.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Hotells_HotelId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotells_HotelId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotells",
                table: "Hotells");

            migrationBuilder.RenameTable(
                name: "Hotells",
                newName: "Hotels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Hotels_HotelId",
                table: "Reservations",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Hotels_HotelId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Hotels_HotelId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hotels",
                table: "Hotels");

            migrationBuilder.RenameTable(
                name: "Hotels",
                newName: "Hotells");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hotells",
                table: "Hotells",
                column: "Id");

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
    }
}
