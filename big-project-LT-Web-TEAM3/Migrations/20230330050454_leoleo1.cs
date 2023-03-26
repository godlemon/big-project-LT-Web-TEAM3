using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class leoleo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "SendDocument",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SendDocument_TeacherId",
                table: "SendDocument",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_SendDocument_Teacher_TeacherId",
                table: "SendDocument",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendDocument_Teacher_TeacherId",
                table: "SendDocument");

            migrationBuilder.DropIndex(
                name: "IX_SendDocument_TeacherId",
                table: "SendDocument");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "SendDocument");
        }
    }
}
