using Microsoft.EntityFrameworkCore.Migrations;

namespace StripProjectEF.Migrations
{
    public partial class commit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Auteurs_AuteurAutuerId",
                table: "Strips");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Reeksen_ReeksId",
                table: "Strips");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Uitgeverijen_UitgeverijId",
                table: "Strips");

            migrationBuilder.DropIndex(
                name: "IX_Strips_AuteurAutuerId",
                table: "Strips");

            migrationBuilder.DropColumn(
                name: "AuteurAutuerId",
                table: "Strips");

            migrationBuilder.RenameColumn(
                name: "UitgeverijId",
                table: "Uitgeverijen",
                newName: "UitgeverijID");

            migrationBuilder.RenameColumn(
                name: "UitgeverijId",
                table: "Strips",
                newName: "UitgeverijID");

            migrationBuilder.RenameColumn(
                name: "ReeksId",
                table: "Strips",
                newName: "ReeksID");

            migrationBuilder.RenameIndex(
                name: "IX_Strips_UitgeverijId",
                table: "Strips",
                newName: "IX_Strips_UitgeverijID");

            migrationBuilder.RenameIndex(
                name: "IX_Strips_ReeksId",
                table: "Strips",
                newName: "IX_Strips_ReeksID");

            migrationBuilder.RenameColumn(
                name: "ReeksId",
                table: "Reeksen",
                newName: "ReeksID");

            migrationBuilder.RenameColumn(
                name: "AutuerId",
                table: "Auteurs",
                newName: "AuteurID");

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Reeksen_ReeksID",
                table: "Strips",
                column: "ReeksID",
                principalTable: "Reeksen",
                principalColumn: "ReeksID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Uitgeverijen_UitgeverijID",
                table: "Strips",
                column: "UitgeverijID",
                principalTable: "Uitgeverijen",
                principalColumn: "UitgeverijID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Reeksen_ReeksID",
                table: "Strips");

            migrationBuilder.DropForeignKey(
                name: "FK_Strips_Uitgeverijen_UitgeverijID",
                table: "Strips");

            migrationBuilder.RenameColumn(
                name: "UitgeverijID",
                table: "Uitgeverijen",
                newName: "UitgeverijId");

            migrationBuilder.RenameColumn(
                name: "UitgeverijID",
                table: "Strips",
                newName: "UitgeverijId");

            migrationBuilder.RenameColumn(
                name: "ReeksID",
                table: "Strips",
                newName: "ReeksId");

            migrationBuilder.RenameIndex(
                name: "IX_Strips_UitgeverijID",
                table: "Strips",
                newName: "IX_Strips_UitgeverijId");

            migrationBuilder.RenameIndex(
                name: "IX_Strips_ReeksID",
                table: "Strips",
                newName: "IX_Strips_ReeksId");

            migrationBuilder.RenameColumn(
                name: "ReeksID",
                table: "Reeksen",
                newName: "ReeksId");

            migrationBuilder.RenameColumn(
                name: "AuteurID",
                table: "Auteurs",
                newName: "AutuerId");

            migrationBuilder.AddColumn<int>(
                name: "AuteurAutuerId",
                table: "Strips",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Strips_AuteurAutuerId",
                table: "Strips",
                column: "AuteurAutuerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Strips_Uitgeverijen_UitgeverijId",
                table: "Strips",
                column: "UitgeverijId",
                principalTable: "Uitgeverijen",
                principalColumn: "UitgeverijId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
