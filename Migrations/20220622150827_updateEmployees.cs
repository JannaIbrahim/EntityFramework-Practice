using Microsoft.EntityFrameworkCore.Migrations;

namespace EFcoreP1.Migrations
{
    public partial class updateEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "EmpID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpID",
                table: "Employees",
                newName: "EmpId");
        }
    }
}
