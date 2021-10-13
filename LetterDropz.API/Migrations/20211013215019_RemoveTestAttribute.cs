using Microsoft.EntityFrameworkCore.Migrations;

namespace LetterDropz.API.Migrations
{
    public partial class RemoveTestAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Users",
                type: "text",
                nullable: true);
        }
    }
}
