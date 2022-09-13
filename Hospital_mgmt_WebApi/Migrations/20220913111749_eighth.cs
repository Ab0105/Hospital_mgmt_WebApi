using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_mgmt_WebApi.Migrations
{
    public partial class eighth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Appointment__Pid__17036CC0",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Room___17F790F9",
                table: "Appointment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Appointment_Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Appointment__Pid__29221CFB",
                table: "Appointment",
                column: "Pid",
                principalTable: "Patient",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Room___2A164134",
                table: "Appointment",
                column: "Room_No",
                principalTable: "Room_Data",
                principalColumn: "Room_No",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Appointment__Pid__29221CFB",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Room___2A164134",
                table: "Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.AddForeignKey(
                name: "FK__Appointment__Pid__17036CC0",
                table: "Appointment",
                column: "Pid",
                principalTable: "Patient",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Room___17F790F9",
                table: "Appointment",
                column: "Room_No",
                principalTable: "Room_Data",
                principalColumn: "Room_No",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
