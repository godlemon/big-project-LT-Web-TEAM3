using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class changeclassify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_classify_classifyId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "Classify",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "classifyId",
                table: "Document",
                newName: "ClassifyId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_classifyId",
                table: "Document",
                newName: "IX_Document_ClassifyId");

            migrationBuilder.AlterColumn<int>(
                name: "ClassifyId",
                table: "Document",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_classify_ClassifyId",
                table: "Document",
                column: "ClassifyId",
                principalTable: "classify",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_classify_ClassifyId",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "ClassifyId",
                table: "Document",
                newName: "classifyId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_ClassifyId",
                table: "Document",
                newName: "IX_Document_classifyId");

            migrationBuilder.AlterColumn<int>(
                name: "classifyId",
                table: "Document",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Classify",
                table: "Document",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_classify_classifyId",
                table: "Document",
                column: "classifyId",
                principalTable: "classify",
                principalColumn: "Id");
        }
    }
}
