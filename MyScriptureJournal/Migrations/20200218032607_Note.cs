using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class Note : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Verse",
                table: "Scripture",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "typeof(int)");

            migrationBuilder.AlterColumn<int>(
                name: "Chapter",
                table: "Scripture",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Scripture",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Scripture");

            migrationBuilder.AlterColumn<decimal>(
                name: "Verse",
                table: "Scripture",
                type: "typeof(int)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Chapter",
                table: "Scripture",
                type: "typeof(int)",
                nullable: true,
                oldClrType: typeof(char));
        }
    }
}
