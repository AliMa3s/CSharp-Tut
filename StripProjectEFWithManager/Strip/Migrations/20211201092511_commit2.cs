using Microsoft.EntityFrameworkCore.Migrations;

namespace StripProjectEF.Migrations
{
    public partial class commit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuteurStrip_Auteurs_AuteursAutuerId",
                table: "AuteurStrip");

            migrationBuilder.DropForeignKey(
                name: "FK_AuteurStrip_Strips_StripsStripId",
                table: "AuteurStrip");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Reeks_ReeksId",
                table: "Strips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reeks",
                table: "Reeks");

            migrationBuilder.RenameTable(
                name: "Reeks",
                newName: "Reeksen");

            migrationBuilder.RenameColumn(
                name: "StripId",
                table: "Strips",
                newName: "StripID");

            migrationBuilder.RenameColumn(
                name: "Nummer",
                table: "Strips",
                newName: "Nr");

            migrationBuilder.RenameColumn(
                name: "StripsStripId",
                table: "AuteurStrip",
                newName: "AuteurID");

            migrationBuilder.RenameColumn(
                name: "AuteursAutuerId",
                table: "AuteurStrip",
                newName: "StripID");

            migrationBuilder.RenameIndex(
                name: "IX_AuteurStrip_StripsStripId",
                table: "AuteurStrip",
                newName: "IX_AuteurStrip_AuteurID");

            migrationBuilder.AddColumn<int>(
                name: "AuteurAutuerId",
                table: "Strips",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reeksen",
                table: "Reeksen",
                column: "ReeksId");

            migrationBuilder.CreateIndex(
                name: "IX_Strips_AuteurAutuerId",
                table: "Strips",
                column: "AuteurAutuerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuteurStrip_Auteurs_AuteurID",
                table: "AuteurStrip",
                column: "AuteurID",
                principalTable: "Auteurs",
                principalColumn: "AutuerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuteurStrip_Strips_StripID",
                table: "AuteurStrip",
                column: "StripID",
                principalTable: "Strips",
                principalColumn: "StripID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Auteurs_AuteurAutuerId",
                table: "Strips",
                column: "AuteurAutuerId",
                principalTable: "Auteurs",
                principalColumn: "AutuerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Reeksen_ReeksId",
                table: "Strips",
                column: "ReeksId",
                principalTable: "Reeksen",
                principalColumn: "ReeksId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuteurStrip_Auteurs_AuteurID",
                table: "AuteurStrip");

            migrationBuilder.DropForeignKey(
                name: "FK_AuteurStrip_Strips_StripID",
                table: "AuteurStrip");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Auteurs_AuteurAutuerId",
                table: "Strips");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Reeksen_ReeksId",
                table: "Strips");

            migrationBuilder.DropIndex(
                name: "IX_Strips_AuteurAutuerId",
                table: "Strips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reeksen",
                table: "Reeksen");

            migrationBuilder.DropColumn(
                name: "AuteurAutuerId",
                table: "Strips");

            migrationBuilder.RenameTable(
                name: "Reeksen",
                newName: "Reeks");

            migrationBuilder.RenameColumn(
                name: "StripID",
                table: "Strips",
                newName: "StripId");

            migrationBuilder.RenameColumn(
                name: "Nr",
                table: "Strips",
                newName: "Nummer");

            migrationBuilder.RenameColumn(
                name: "AuteurID",
                table: "AuteurStrip",
                newName: "StripsStripId");

            migrationBuilder.RenameColumn(
                name: "StripID",
                table: "AuteurStrip",
                newName: "AuteursAutuerId");

            migrationBuilder.RenameIndex(
                name: "IX_AuteurStrip_AuteurID",
                table: "AuteurStrip",
                newName: "IX_AuteurStrip_StripsStripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reeks",
                table: "Reeks",
                column: "ReeksId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuteurStrip_Auteurs_AuteursAutuerId",
                table: "AuteurStrip",
                column: "AuteursAutuerId",
                principalTable: "Auteurs",
                principalColumn: "AutuerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuteurStrip_Strips_StripsStripId",
                table: "AuteurStrip",
                column: "StripsStripId",
                principalTable: "Strips",
                principalColumn: "StripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Reeks_ReeksId",
                table: "Strips",
                column: "ReeksId",
                principalTable: "Reeks",
                principalColumn: "ReeksId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
