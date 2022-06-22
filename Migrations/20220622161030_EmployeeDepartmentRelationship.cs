using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFcoreP1.Migrations
{
    public partial class EmployeeDepartmentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 22, 18, 10, 29, 136, DateTimeKind.Local).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 22, 17, 50, 16, 880, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptID",
                table: "Employees",
                column: "DepartmentDeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptID",
                table: "Employees",
                column: "DepartmentDeptID",
                principalTable: "Departments",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptID",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 22, 17, 50, 16, 880, DateTimeKind.Local).AddTicks(5522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 22, 18, 10, 29, 136, DateTimeKind.Local).AddTicks(8540));
        }
    }
}
