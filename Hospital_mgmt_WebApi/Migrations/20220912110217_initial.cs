using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_mgmt_WebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Doctor_name = table.Column<string>(type: "text", nullable: false),
                    Dept = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone_no = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    Disease = table.Column<string>(type: "text", nullable: false),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Patient__C5705938D7528577", x => x.Pid);
                    table.ForeignKey(
                        name: "FK__Patient__Doctor___38996AB5",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bill_Data",
                columns: table => new
                {
                    Bill_No = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Patient_Type = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Doctor_Fees = table.Column<int>(nullable: true),
                    Room_Charge = table.Column<int>(nullable: true),
                    Operation_Charge = table.Column<int>(nullable: true),
                    Medicine_Fees = table.Column<int>(nullable: true),
                    Total_Days = table.Column<int>(nullable: true),
                    Lab_Fees = table.Column<int>(nullable: true),
                    Total_amount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bill_Dat__CF6FA49F09167DB9", x => x.Bill_No);
                    table.ForeignKey(
                        name: "FK__Bill_Data__Docto__4CA06362",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Bill_Data__Pid__4BAC3F29",
                        column: x => x.Pid,
                        principalTable: "Patient",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lab",
                columns: table => new
                {
                    Lab_id = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Test_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Test_Type = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Patient_Type = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab", x => x.Lab_id);
                    table.ForeignKey(
                        name: "FK__Lab__Doctor_id__3C69FB99",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Lab__Pid__3B75D760",
                        column: x => x.Pid,
                        principalTable: "Patient",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Outpatient",
                columns: table => new
                {
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Treatment_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Lab_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Outpatie__C5705938BDE1C427", x => x.Pid);
                    table.ForeignKey(
                        name: "FK__Outpatien__Docto__47DBAE45",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Outpatien__Lab_i__48CFD27E",
                        column: x => x.Lab_id,
                        principalTable: "Lab",
                        principalColumn: "Lab_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room_Data",
                columns: table => new
                {
                    Room_No = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Treatment_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Lab_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Room_Dat__19EF81FC82B760DD", x => x.Room_No);
                    table.ForeignKey(
                        name: "FK__Room_Data__Docto__403A8C7D",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Room_Data__Lab_i__3F466844",
                        column: x => x.Lab_id,
                        principalTable: "Lab",
                        principalColumn: "Lab_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENT",
                columns: table => new
                {
                    Appointment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Doctor_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Room_No = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    DateofVisit = table.Column<DateTime>(name: "Date of Visit", type: "date", nullable: true),
                    AdmissionDate = table.Column<DateTime>(name: "Admission Date", type: "date", nullable: true),
                    DischargeDate = table.Column<DateTime>(name: "Discharge Date", type: "date", nullable: true),
                    Remarks = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__APPOINTMENT__Pid__4E88ABD4",
                        column: x => x.Pid,
                        principalTable: "Patient",
                        principalColumn: "Pid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__APPOINTME__Room___4F7CD00D",
                        column: x => x.Room_No,
                        principalTable: "Room_Data",
                        principalColumn: "Room_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InPatient",
                columns: table => new
                {
                    Pid = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Room_no = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Doctor_id = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Admission_date = table.Column<DateTime>(type: "date", nullable: false),
                    Discharge_date = table.Column<DateTime>(type: "date", nullable: true),
                    Lab_id = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Amount_per_day = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__InPatien__C5705938693B5385", x => x.Pid);
                    table.ForeignKey(
                        name: "FK__InPatient__Docto__440B1D61",
                        column: x => x.Doctor_id,
                        principalTable: "Doctor",
                        principalColumn: "Doctor_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__InPatient__Lab_i__44FF419A",
                        column: x => x.Lab_id,
                        principalTable: "Lab",
                        principalColumn: "Lab_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__InPatient__Room___4316F928",
                        column: x => x.Room_no,
                        principalTable: "Room_Data",
                        principalColumn: "Room_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_Pid",
                table: "APPOINTMENT",
                column: "Pid");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_Room_No",
                table: "APPOINTMENT",
                column: "Room_No");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Data_Doctor_id",
                table: "Bill_Data",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Data_Pid",
                table: "Bill_Data",
                column: "Pid");

            migrationBuilder.CreateIndex(
                name: "IX_InPatient_Doctor_id",
                table: "InPatient",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_InPatient_Lab_id",
                table: "InPatient",
                column: "Lab_id");

            migrationBuilder.CreateIndex(
                name: "IX_InPatient_Room_no",
                table: "InPatient",
                column: "Room_no");

            migrationBuilder.CreateIndex(
                name: "IX_Lab_Doctor_id",
                table: "Lab",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lab_Pid",
                table: "Lab",
                column: "Pid");

            migrationBuilder.CreateIndex(
                name: "IX_Outpatient_Doctor_id",
                table: "Outpatient",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Outpatient_Lab_id",
                table: "Outpatient",
                column: "Lab_id");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Doctor_id",
                table: "Patient",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Data_Doctor_id",
                table: "Room_Data",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Data_Lab_id",
                table: "Room_Data",
                column: "Lab_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENT");

            migrationBuilder.DropTable(
                name: "Bill_Data");

            migrationBuilder.DropTable(
                name: "InPatient");

            migrationBuilder.DropTable(
                name: "Outpatient");

            migrationBuilder.DropTable(
                name: "Room_Data");

            migrationBuilder.DropTable(
                name: "Lab");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
