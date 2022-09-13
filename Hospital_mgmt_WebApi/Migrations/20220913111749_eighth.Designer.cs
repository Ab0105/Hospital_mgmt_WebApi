﻿// <auto-generated />
using System;
using Hospital_mgmt_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospital_mgmt_WebApi.Migrations
{
    [DbContext(typeof(SprintOneTeam3Context))]
    [Migration("20220913111749_eighth")]
    partial class eighth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Appointment_Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AdmissionDate")
                        .HasColumnName("Admission Date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateOfVisit")
                        .HasColumnName("Date of Visit")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DischargeDate")
                        .HasColumnName("Discharge Date")
                        .HasColumnType("date");

                    b.Property<string>("DoctorName")
                        .HasColumnName("Doctor_Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Pid")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Remarks")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("RoomNo")
                        .HasColumnName("Room_No")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("AppointmentId");

                    b.HasIndex("Pid");

                    b.HasIndex("RoomNo");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.BillData", b =>
                {
                    b.Property<int>("BillNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Bill_No")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DoctorFees")
                        .HasColumnName("Doctor_Fees")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnName("Doctor_Id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<decimal?>("LabFees")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Lab_Fees")
                        .HasColumnType("numeric(18, 0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal>("MedicineFees")
                        .HasColumnName("Medicine_Fees")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal?>("OperationCharges")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Operation_Charges")
                        .HasColumnType("numeric(18, 0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("PatientType")
                        .HasColumnName("Patient_Type")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Pid")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<decimal?>("RoomCharges")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Room_Charges")
                        .HasColumnType("numeric(18, 0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TotalAmount")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("Total_Amount")
                        .HasColumnType("numeric(33, 0)")
                        .HasComputedColumnSql("(((([Doctor_Fees]+[Room_Charges]*[Total_days])+[Operation_Charges])+[Medicine_Fees])+[Lab_Fees])");

                    b.Property<int?>("TotalDays")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Total_days")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("BillNo")
                        .HasName("PK__Bill_Dat__CF6FA49F05935736");

                    b.HasIndex("DoctorId");

                    b.HasIndex("Pid");

                    b.ToTable("Bill_Data");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Doctor", b =>
                {
                    b.Property<string>("DoctorId")
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Dept")
                        .HasColumnType("text");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnName("Doctor_name")
                        .HasColumnType("text");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.InPatient", b =>
                {
                    b.Property<string>("Pid")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnName("Admission_date")
                        .HasColumnType("date");

                    b.Property<decimal>("AmountPerDay")
                        .HasColumnName("Amount_per_day")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<DateTime?>("DischargeDate")
                        .HasColumnName("Discharge_date")
                        .HasColumnType("date");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("LabId")
                        .HasColumnName("Lab_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("RoomNo")
                        .IsRequired()
                        .HasColumnName("Room_no")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Pid")
                        .HasName("PK__InPatien__C5705938693B5385");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LabId");

                    b.HasIndex("RoomNo");

                    b.ToTable("InPatient");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Lab", b =>
                {
                    b.Property<string>("LabId")
                        .HasColumnName("Lab_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("DoctorId")
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("PatientType")
                        .HasColumnName("Patient_Type")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Pid")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime>("TestDate")
                        .HasColumnName("Test_Date")
                        .HasColumnType("date");

                    b.Property<string>("TestType")
                        .HasColumnName("Test_Type")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("LabId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("Pid");

                    b.ToTable("Lab");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Outpatient", b =>
                {
                    b.Property<string>("Pid")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("LabId")
                        .HasColumnName("Lab_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime>("TreatmentDate")
                        .HasColumnName("Treatment_Date")
                        .HasColumnType("date");

                    b.HasKey("Pid")
                        .HasName("PK__Outpatie__C5705938BDE1C427");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LabId");

                    b.ToTable("Outpatient");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Patient", b =>
                {
                    b.Property<string>("Pid")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<decimal>("Age")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DoctorId")
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PhoneNo")
                        .HasColumnName("Phone_no")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Pid")
                        .HasName("PK__Patient__C5705938D7528577");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.RoomData", b =>
                {
                    b.Property<string>("RoomNo")
                        .HasColumnName("Room_No")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("DoctorId")
                        .HasColumnName("Doctor_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("LabId")
                        .HasColumnName("Lab_id")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime?>("TreatmentDate")
                        .HasColumnName("Treatment_Date")
                        .HasColumnType("date");

                    b.HasKey("RoomNo")
                        .HasName("PK__Room_Dat__19EF81FC82B760DD");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LabId");

                    b.ToTable("Room_Data");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Appointment", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Patient", "P")
                        .WithMany("Appointment")
                        .HasForeignKey("Pid")
                        .HasConstraintName("FK__Appointment__Pid__29221CFB");

                    b.HasOne("Hospital_mgmt_WebApi.Model.RoomData", "RoomNoNavigation")
                        .WithMany("Appointment")
                        .HasForeignKey("RoomNo")
                        .HasConstraintName("FK__Appointme__Room___2A164134");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.BillData", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("BillData")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Bill_Data__Docto__114A936A")
                        .IsRequired();

                    b.HasOne("Hospital_mgmt_WebApi.Model.Patient", "P")
                        .WithMany("BillData")
                        .HasForeignKey("Pid")
                        .HasConstraintName("FK__Bill_Data__Pid__10566F31")
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.InPatient", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("InPatient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__InPatient__Docto__440B1D61")
                        .IsRequired();

                    b.HasOne("Hospital_mgmt_WebApi.Model.Lab", "Lab")
                        .WithMany("InPatient")
                        .HasForeignKey("LabId")
                        .HasConstraintName("FK__InPatient__Lab_i__44FF419A");

                    b.HasOne("Hospital_mgmt_WebApi.Model.RoomData", "RoomNoNavigation")
                        .WithMany("InPatient")
                        .HasForeignKey("RoomNo")
                        .HasConstraintName("FK__InPatient__Room___4316F928")
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Lab", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("Lab")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Lab__Doctor_id__3C69FB99");

                    b.HasOne("Hospital_mgmt_WebApi.Model.Patient", "P")
                        .WithMany("Lab")
                        .HasForeignKey("Pid")
                        .HasConstraintName("FK__Lab__Pid__3B75D760");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Outpatient", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("Outpatient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Outpatien__Docto__47DBAE45")
                        .IsRequired();

                    b.HasOne("Hospital_mgmt_WebApi.Model.Lab", "Lab")
                        .WithMany("Outpatient")
                        .HasForeignKey("LabId")
                        .HasConstraintName("FK__Outpatien__Lab_i__48CFD27E");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.Patient", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("Patient")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Patient__Doctor___38996AB5");
                });

            modelBuilder.Entity("Hospital_mgmt_WebApi.Model.RoomData", b =>
                {
                    b.HasOne("Hospital_mgmt_WebApi.Model.Doctor", "Doctor")
                        .WithMany("RoomData")
                        .HasForeignKey("DoctorId")
                        .HasConstraintName("FK__Room_Data__Docto__403A8C7D");

                    b.HasOne("Hospital_mgmt_WebApi.Model.Lab", "Lab")
                        .WithMany("RoomData")
                        .HasForeignKey("LabId")
                        .HasConstraintName("FK__Room_Data__Lab_i__3F466844");
                });
#pragma warning restore 612, 618
        }
    }
}
