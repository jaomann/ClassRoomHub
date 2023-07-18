using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class correcao_na_modelagem_de_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "CHAR(20)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
