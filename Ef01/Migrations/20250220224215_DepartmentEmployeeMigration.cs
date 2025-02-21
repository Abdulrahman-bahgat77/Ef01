using Microsoft.EntityFrameworkCore.Migrations;

namespace Ef01.Migrations
{
    public partial class DepartmentEmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentsId",
                table: "Employees",
                column: "DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentsId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentsId",
                table: "Employees");
        }
    }
}
