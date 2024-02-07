using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppRazorPages.Migrations
{
    public partial class EngineCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EngineCar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineCar",
                table: "Users");
        }
    }
}
