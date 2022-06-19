using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Data.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "Player",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Player_GroupID",
                table: "Player",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Group_GroupID",
                table: "Player",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Group_GroupID",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_GroupID",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "Player");
        }
    }
}
