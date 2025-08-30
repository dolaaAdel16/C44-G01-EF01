using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    //public partial class InitialCreation : Migration
    //{
    //    /// <inheritdoc />
    //    protected override void Up(MigrationBuilder migrationBuilder)
    //    {
    //        migrationBuilder.CreateTable(
    //            name: "Departments",
    //            columns: table => new
    //            {
    //                Id = table.Column<int>(type: "int", nullable: false)
    //                    .Annotation("SqlServer:Identity", "1, 1"),
    //                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
    //                DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
    //            },
    //            constraints: table =>
    //            {
    //                table.PrimaryKey("PK_Departments", x => x.Id);
    //            });

    //        migrationBuilder.CreateTable(
    //            name: "Employees",
    //            columns: table => new
    //            {
    //                EmpId = table.Column<string>(type: "nvarchar(450)", nullable: false),
    //                EmployeeName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
    //                Age = table.Column<int>(type: "int", nullable: true),
    //                Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
    //                Salary = table.Column<decimal>(type: "money", nullable: false),
    //                DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
    //            },
    //            constraints: table =>
    //            {
    //                table.PrimaryKey("PK_Employees", x => x.EmpId);
    //            });
    //    }

    //    /// <inheritdoc />
    //    protected override void Down(MigrationBuilder migrationBuilder)
    //    {
    //        migrationBuilder.DropTable(
    //            name: "Departments");

    //        migrationBuilder.DropTable(
    //            name: "Employees");
    //    }
    //}
}
