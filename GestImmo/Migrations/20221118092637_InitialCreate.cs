using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bien",
                columns: table => new
                {
                    BienId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomBien = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<int>(type: "integer", nullable: false),
                    Surface = table.Column<int>(type: "integer", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    LogementId = table.Column<int>(type: "integer", nullable: true),
                    NbPiece = table.Column<int>(type: "integer", nullable: true),
                    NbChambre = table.Column<int>(type: "integer", nullable: true),
                    Cave = table.Column<int>(type: "integer", nullable: true),
                    Parking = table.Column<int>(type: "integer", nullable: true),
                    AppartementId = table.Column<int>(type: "integer", nullable: true),
                    Etage = table.Column<int>(type: "integer", nullable: true),
                    Ascenseur = table.Column<bool>(type: "boolean", nullable: true),
                    Chauffage = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bien", x => x.BienId);
                });

            migrationBuilder.CreateTable(
                name: "Locataire",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataire", x => x.LocataireId);
                });

            migrationBuilder.CreateTable(
                name: "Prestataire",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    RaisonSociale = table.Column<string>(type: "text", nullable: false),
                    Telephone = table.Column<string>(type: "text", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataire", x => x.PrestataireId);
                });

            migrationBuilder.CreateTable(
                name: "Pret",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Montant = table.Column<int>(type: "integer", nullable: false),
                    Apport = table.Column<int>(type: "integer", nullable: false),
                    Duree = table.Column<string>(type: "text", nullable: false),
                    TauxInteret = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pret", x => x.PretId);
                });

            migrationBuilder.CreateTable(
                name: "Contrat",
                columns: table => new
                {
                    ContratId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoutLoyer = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<string>(type: "text", nullable: false),
                    DateFin = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrat", x => x.ContratId);
                    table.ForeignKey(
                        name: "FK_Contrat_Bien_BienId",
                        column: x => x.BienId,
                        principalTable: "Bien",
                        principalColumn: "BienId");
                });

            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateIntervention = table.Column<string>(type: "text", nullable: false),
                    MontantTTC = table.Column<int>(type: "integer", nullable: false),
                    Information = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Intervention_Bien_BienId",
                        column: x => x.BienId,
                        principalTable: "Bien",
                        principalColumn: "BienId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contrat_BienId",
                table: "Contrat",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_BienId",
                table: "Intervention",
                column: "BienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrat");

            migrationBuilder.DropTable(
                name: "Intervention");

            migrationBuilder.DropTable(
                name: "Locataire");

            migrationBuilder.DropTable(
                name: "Prestataire");

            migrationBuilder.DropTable(
                name: "Pret");

            migrationBuilder.DropTable(
                name: "Bien");
        }
    }
}
