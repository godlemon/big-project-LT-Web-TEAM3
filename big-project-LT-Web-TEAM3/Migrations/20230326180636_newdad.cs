using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace big_project_LT_Web_TEAM3.Migrations
{
    /// <inheritdoc />
    public partial class newdad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocumentName",
                table: "Document",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentName",
                table: "Document");
        }
    }
}
