using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_mgmt_WebApi.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_APPOINTMENT",
                table: "APPOINTMENT",
                column: "Appointment_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_APPOINTMENT",
                table: "APPOINTMENT");
        }
    }
}
