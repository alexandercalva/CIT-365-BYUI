using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class BookName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "Scripture");

            migrationBuilder.AddColumn<string>(
                name: "BookModels",
                table: "Scripture",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookModels",
                table: "Scripture");

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "Scripture",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
