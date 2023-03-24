using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class _315 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_classify_ClassifyId",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classify",
                table: "classify");

            migrationBuilder.RenameTable(
                name: "classify",
                newName: "Classify");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classify",
                table: "Classify",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Classify_ClassifyId",
                table: "Document",
                column: "ClassifyId",
                principalTable: "Classify",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Classify_ClassifyId",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classify",
                table: "Classify");

            migrationBuilder.RenameTable(
                name: "Classify",
                newName: "classify");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classify",
                table: "classify",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_classify_ClassifyId",
                table: "Document",
                column: "ClassifyId",
                principalTable: "classify",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
