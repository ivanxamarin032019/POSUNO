using Microsoft.EntityFrameworkCore.Migrations;

namespace POSUNO.Api.Migrations
{
    public partial class AddCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirsName",
                table: "Users",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "FirsName");
        }
    }
}
