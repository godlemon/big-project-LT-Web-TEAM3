using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class haha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "classifyId",
                table: "Document",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "classify",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classify", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SendDocument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teacherId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendDocument_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendDocument_Teacher_teacherId",
                        column: x => x.teacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_classifyId",
                table: "Document",
                column: "classifyId");

            migrationBuilder.CreateIndex(
                name: "IX_SendDocument_DocumentId",
                table: "SendDocument",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SendDocument_teacherId",
                table: "SendDocument",
                column: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_classify_classifyId",
                table: "Document",
                column: "classifyId",
                principalTable: "classify",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_classify_classifyId",
                table: "Document");

            migrationBuilder.DropTable(
                name: "classify");

            migrationBuilder.DropTable(
                name: "SendDocument");

            migrationBuilder.DropIndex(
                name: "IX_Document_classifyId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "classifyId",
                table: "Document");
        }
    }
}
