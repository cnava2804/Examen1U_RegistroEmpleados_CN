using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen1U_RegistroEmpleados_CN.Data.Migrations
{
    public partial class AddEmpRegistration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeRegistrations",
                columns: table => new
                {
                    EmpRegistrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpRegistrationNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationLastNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationNickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationDirection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationCellPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpRegistrationObservations = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRegistrations", x => x.EmpRegistrationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRegistrations");
        }
    }
}
