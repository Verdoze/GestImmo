using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    /// <inheritdoc />
    public partial class heritage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppartementId",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Ascenseur",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Cave",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Chauffage",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Etage",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "LogementId",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "NbChambre",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "NbPiece",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "Bien");

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    BoxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Box_Bien_BienId",
                        column: x => x.BienId,
                        principalTable: "Bien",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logement",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    LogementId = table.Column<int>(type: "integer", nullable: false),
                    NbPiece = table.Column<int>(type: "integer", nullable: false),
                    NbChambre = table.Column<int>(type: "integer", nullable: false),
                    Cave = table.Column<int>(type: "integer", nullable: false),
                    Parking = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logement", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Logement_Bien_BienId",
                        column: x => x.BienId,
                        principalTable: "Bien",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appartement",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    AppartementId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Ascenseur = table.Column<bool>(type: "boolean", nullable: false),
                    Chauffage = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartement", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Appartement_Logement_BienId",
                        column: x => x.BienId,
                        principalTable: "Logement",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maison",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    MaisonID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maison", x => x.BienId);
                    table.ForeignKey(
                        name: "FK_Maison_Logement_BienId",
                        column: x => x.BienId,
                        principalTable: "Logement",
                        principalColumn: "BienId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Maison");

            migrationBuilder.DropTable(
                name: "Logement");

            migrationBuilder.AddColumn<int>(
                name: "AppartementId",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ascenseur",
                table: "Bien",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cave",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Chauffage",
                table: "Bien",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Bien",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Etage",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LogementId",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbChambre",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NbPiece",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parking",
                table: "Bien",
                type: "integer",
                nullable: true);
        }
    }
}
