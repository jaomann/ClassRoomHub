using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class Estabelecida_FK_Teacher_to_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teacher_TeacherID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TeacherID",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserGuid",
                table: "Teacher",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_UserGuid",
                table: "Teacher",
                column: "UserGuid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Users_UserGuid",
                table: "Teacher",
                column: "UserGuid",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Users_UserGuid",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_UserGuid",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "UserGuid",
                table: "Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeacherID",
                table: "Users",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teacher_TeacherID",
                table: "Users",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
