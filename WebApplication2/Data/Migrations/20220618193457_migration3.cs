using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Player");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
