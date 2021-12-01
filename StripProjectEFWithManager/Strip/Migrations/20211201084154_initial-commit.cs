using Microsoft.EntityFrameworkCore.Migrations;

namespace StripProjectEF.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    AutuerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.AutuerId);
                });

            migrationBuilder.CreateTable(
                name: "Reeks",
                columns: table => new
                {
                    ReeksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reeks", x => x.ReeksId);
                });

            migrationBuilder.CreateTable(
                name: "Uitgeverijen",
                columns: table => new
                {
                    UitgeverijId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uitgeverijen", x => x.UitgeverijId);
                });

            migrationBuilder.CreateTable(
                name: "Strips",
                columns: table => new
                {
                    StripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nummer = table.Column<int>(type: "int", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UitgeverijId = table.Column<int>(type: "int", nullable: true),
                    ReeksId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strips", x => x.StripId);
                    table.ForeignKey(
                        name: "FK_Strips_Reeks_ReeksId",
                        column: x => x.ReeksId,
                        principalTable: "Reeks",
                        principalColumn: "ReeksId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Strips_Uitgeverijen_UitgeverijId",
                        column: x => x.UitgeverijId,
                        principalTable: "Uitgeverijen",
                        principalColumn: "UitgeverijId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuteurStrip",
                columns: table => new
                {
                    AuteursAutuerId = table.Column<int>(type: "int", nullable: false),
                    StripsStripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuteurStrip", x => new { x.AuteursAutuerId, x.StripsStripId });
                    table.ForeignKey(
                        name: "FK_AuteurStrip_Auteurs_AuteursAutuerId",
                        column: x => x.AuteursAutuerId,
                        principalTable: "Auteurs",
                        principalColumn: "AutuerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuteurStrip_Strips_StripsStripId",
                        column: x => x.StripsStripId,
                        principalTable: "Strips",
                        principalColumn: "StripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuteurStrip_StripsStripId",
                table: "AuteurStrip",
                column: "StripsStripId");

            migrationBuilder.CreateIndex(
                name: "IX_Strips_ReeksId",
                table: "Strips",
                column: "ReeksId");

            migrationBuilder.CreateIndex(
                name: "IX_Strips_UitgeverijId",
                table: "Strips",
                column: "UitgeverijId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuteurStrip");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "Strips");

            migrationBuilder.DropTable(
                name: "Reeks");

            migrationBuilder.DropTable(
                name: "Uitgeverijen");
        }
    }
}
