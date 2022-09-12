using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class SprintOneTeam3Context : DbContext
    {
        public SprintOneTeam3Context()
        {
        }

        public SprintOneTeam3Context(DbContextOptions<SprintOneTeam3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<BillData> BillData { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<InPatient> InPatient { get; set; }
        public virtual DbSet<Lab> Lab { get; set; }
        public virtual DbSet<Outpatient> Outpatient { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<RoomData> RoomData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=True;Database=SprintOneTeam3");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("Admission Date")
                    .HasColumnType("date");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateOfVisit)
                    .HasColumnName("Date of Visit")
                    .HasColumnType("date");

                entity.Property(e => e.DischargeDate)
                    .HasColumnName("Discharge Date")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasColumnName("Doctor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNo)
                    .IsRequired()
                    .HasColumnName("Room_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany()
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTMENT__Pid__4E88ABD4");

                entity.HasOne(d => d.RoomNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RoomNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__Room___4F7CD00D");
            });

            modelBuilder.Entity<BillData>(entity =>
            {
                entity.HasKey(e => e.BillNo)
                    .HasName("PK__Bill_Dat__CF6FA49F09167DB9");

                entity.ToTable("Bill_Data");

                entity.Property(e => e.BillNo)
                    .HasColumnName("Bill_No")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorFees).HasColumnName("Doctor_Fees");

                entity.Property(e => e.DoctorId)
                    .IsRequired()
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LabFees).HasColumnName("Lab_Fees");

                entity.Property(e => e.MedicineFees).HasColumnName("Medicine_Fees");

                entity.Property(e => e.OperationCharge).HasColumnName("Operation_Charge");

                entity.Property(e => e.PatientType)
                    .IsRequired()
                    .HasColumnName("Patient_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomCharge).HasColumnName("Room_Charge");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_amount");

                entity.Property(e => e.TotalDays).HasColumnName("Total_Days");

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.BillData)
                //    .HasForeignKey(d => d.DoctorId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Bill_Data__Docto__4CA06362");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.BillData)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill_Data__Pid__4BAC3F29");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dept).HasColumnType("text");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasColumnName("Doctor_name")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<InPatient>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__InPatien__C5705938693B5385");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("Admission_date")
                    .HasColumnType("date");

                entity.Property(e => e.AmountPerDay)
                    .HasColumnName("Amount_per_day")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DischargeDate)
                    .HasColumnName("Discharge_date")
                    .HasColumnType("date");

                entity.Property(e => e.DoctorId)
                    .IsRequired()
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LabId)
                    .HasColumnName("Lab_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNo)
                    .IsRequired()
                    .HasColumnName("Room_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.InPatient)
                //    .HasForeignKey(d => d.DoctorId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__InPatient__Docto__440B1D61");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.InPatient)
                    .HasForeignKey(d => d.LabId)
                    .HasConstraintName("FK__InPatient__Lab_i__44FF419A");

                entity.HasOne(d => d.RoomNoNavigation)
                    .WithMany(p => p.InPatient)
                    .HasForeignKey(d => d.RoomNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InPatient__Room___4316F928");
            });

            modelBuilder.Entity<Lab>(entity =>
            {
                entity.Property(e => e.LabId)
                    .HasColumnName("Lab_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PatientType)
                    .HasColumnName("Patient_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate)
                    .HasColumnName("Test_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TestType)
                    .IsRequired()
                    .HasColumnName("Test_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.Lab)
                //    .HasForeignKey(d => d.DoctorId)
                //    .HasConstraintName("FK__Lab__Doctor_id__3C69FB99");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Lab)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__Lab__Pid__3B75D760");
            });

            modelBuilder.Entity<Outpatient>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Outpatie__C5705938BDE1C427");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId)
                    .IsRequired()
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LabId)
                    .HasColumnName("Lab_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDate)
                    .HasColumnName("Treatment_Date")
                    .HasColumnType("date");

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.Outpatient)
                //    .HasForeignKey(d => d.DoctorId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Outpatien__Docto__47DBAE45");

                //entity.HasOne(d => d.Lab)
                //    .WithMany(p => p.Outpatient)
                //    .HasForeignKey(d => d.LabId)
                //    .HasConstraintName("FK__Outpatien__Lab_i__48CFD27E");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Patient__C5705938D7528577");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Disease)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("Phone_no")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 0)");

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.Patient)
                //    .HasForeignKey(d => d.DoctorId)
                //    .HasConstraintName("FK__Patient__Doctor___38996AB5");
            });

            modelBuilder.Entity<RoomData>(entity =>
            {
                entity.HasKey(e => e.RoomNo)
                    .HasName("PK__Room_Dat__19EF81FC82B760DD");

                entity.ToTable("Room_Data");

                entity.Property(e => e.RoomNo)
                    .HasColumnName("Room_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId)
                    .HasColumnName("Doctor_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LabId)
                    .HasColumnName("Lab_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TreatmentDate)
                    .HasColumnName("Treatment_Date")
                    .HasColumnType("date");

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.RoomData)
                //    .HasForeignKey(d => d.DoctorId)
                //    .HasConstraintName("FK__Room_Data__Docto__403A8C7D");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.RoomData)
                    .HasForeignKey(d => d.LabId)
                    .HasConstraintName("FK__Room_Data__Lab_i__3F466844");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
