using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class haha1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileDocument",
                table: "SendDocument",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Filename",
                table: "Document",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileDocument",
                table: "SendDocument");

            migrationBuilder.DropColumn(
                name: "Filename",
                table: "Document");
        }
    }
}
