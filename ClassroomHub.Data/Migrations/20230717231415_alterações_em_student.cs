using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class alterações_em_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Users",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Users",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Users",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Users",
                newName: "StudentID");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
