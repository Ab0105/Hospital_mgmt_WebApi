using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class BillData
    {
        public int BillNo { get; set; }
        public string Pid { get; set; }
        public string PatientType { get; set; }
        public string DoctorId { get; set; }
        public decimal DoctorFees { get; set; }
        public decimal? RoomCharges { get; set; }
        public decimal? OperationCharges { get; set; }
        public decimal MedicineFees { get; set; }
        public int? TotalDays { get; set; }
        public decimal? LabFees { get; set; }
        public decimal? TotalAmount { get; set; }

        //public virtual Doctor Doctor { get; set; }
        //public virtual Patient P { get; set; }
    }
}
