using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    /// <inheritdoc />
    public partial class GestImmo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chauffage",
                table: "Appartement",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<string>(
                name: "Ascenseur",
                table: "Appartement",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Chauffage",
                table: "Appartement",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "Ascenseur",
                table: "Appartement",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
