using Microsoft.EntityFrameworkCore.Migrations;

namespace IELTSRegistrationEF.Migrations
{
    public partial class ADDREGISTRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Registration",
                newName: "DOB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Registration",
                newName: "DateOfBirth");
        }
    }
}
