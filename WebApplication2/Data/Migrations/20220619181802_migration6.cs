using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Data.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Group_GroupId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Player",
                newName: "GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Player_GroupId",
                table: "Player",
                newName: "IX_Player_GroupID");

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

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "Player",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_GroupID",
                table: "Player",
                newName: "IX_Player_GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Group_GroupId",
                table: "Player",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
