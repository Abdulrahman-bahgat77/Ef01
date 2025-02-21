using Microsoft.EntityFrameworkCore.Migrations;

namespace Ef01.Migrations
{
    public partial class SetDeleteRuleCascadeInDepartmentEmployeeRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentsId",
                table: "Employees",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
