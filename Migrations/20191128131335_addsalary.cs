using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeCF.Migrations
{
    public partial class addsalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "salary",
                table: "Employees",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salary",
                table: "Employees");
        }
    }
}
