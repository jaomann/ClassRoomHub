using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class alteractivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Module_ModuleId",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Atividade_Student_StudentId",
                table: "Atividade");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Atividade_ActivityId",
                table: "Entregas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atividade",
                table: "Atividade");

            migrationBuilder.DropColumn(
                name: "GradePoints",
                table: "Atividade");

            migrationBuilder.RenameTable(
                name: "Atividade",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Atividade_StudentId",
                table: "Activities",
                newName: "IX_Activities_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Atividade_ModuleId",
                table: "Activities",
                newName: "IX_Activities_ModuleId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Activities",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActivityScore",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Module_ModuleId",
                table: "Activities",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Student_StudentId",
                table: "Activities",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Activities_ActivityId",
                table: "Entregas",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Module_ModuleId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Student_StudentId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Entregas_Activities_ActivityId",
                table: "Entregas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ActivityScore",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Atividade");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_StudentId",
                table: "Atividade",
                newName: "IX_Atividade_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_ModuleId",
                table: "Atividade",
                newName: "IX_Atividade_ModuleId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Atividade",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Atividade",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "GradePoints",
                table: "Atividade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atividade",
                table: "Atividade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Module_ModuleId",
                table: "Atividade",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atividade_Student_StudentId",
                table: "Atividade",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entregas_Atividade_ActivityId",
                table: "Entregas",
                column: "ActivityId",
                principalTable: "Atividade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
