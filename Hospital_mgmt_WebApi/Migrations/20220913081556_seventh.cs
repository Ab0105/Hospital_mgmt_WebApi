using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_mgmt_WebApi.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__APPOINTMENT__Pid__4E88ABD4",
                table: "APPOINTMENT");

            migrationBuilder.DropForeignKey(
                name: "FK__APPOINTME__Room___4F7CD00D",
                table: "APPOINTMENT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APPOINTMENT",
                table: "APPOINTMENT");

            migrationBuilder.RenameTable(
                name: "APPOINTMENT",
                newName: "Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_APPOINTMENT_Room_No",
                table: "Appointment",
                newName: "IX_Appointment_Room_No");

            migrationBuilder.RenameIndex(
                name: "IX_APPOINTMENT_Pid",
                table: "Appointment",
                newName: "IX_Appointment_Pid");

            migrationBuilder.AlterColumn<string>(
                name: "Room_No",
                table: "Appointment",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Pid",
                table: "Appointment",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Doctor_Name",
                table: "Appointment",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Appointment__Pid__17036CC0",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Room___17F790F9",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "APPOINTMENT");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_Room_No",
                table: "APPOINTMENT",
                newName: "IX_APPOINTMENT_Room_No");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_Pid",
                table: "APPOINTMENT",
                newName: "IX_APPOINTMENT_Pid");

            migrationBuilder.AlterColumn<string>(
                name: "Room_No",
                table: "APPOINTMENT",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pid",
                table: "APPOINTMENT",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Doctor_Name",
                table: "APPOINTMENT",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_APPOINTMENT",
                table: "APPOINTMENT",
                column: "Appointment_Id");

            migrationBuilder.AddForeignKey(
                name: "FK__APPOINTMENT__Pid__4E88ABD4",
                table: "APPOINTMENT",
                column: "Pid",
                principalTable: "Patient",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__APPOINTME__Room___4F7CD00D",
                table: "APPOINTMENT",
                column: "Room_No",
                principalTable: "Room_Data",
                principalColumn: "Room_No",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
