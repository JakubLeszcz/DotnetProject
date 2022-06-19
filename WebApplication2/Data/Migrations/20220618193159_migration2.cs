using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Score",
                table: "Player",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Player",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }
    }
}
