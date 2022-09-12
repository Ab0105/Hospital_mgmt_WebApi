using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class BillData
    {
        public string BillNo { get; set; }
        public string Pid { get; set; }
        public string PatientType { get; set; }
        public string DoctorId { get; set; }
        public int? DoctorFees { get; set; }
        public int? RoomCharge { get; set; }
        public int? OperationCharge { get; set; }
        public int? MedicineFees { get; set; }
        public int? TotalDays { get; set; }
        public int? LabFees { get; set; }
        public int? TotalAmount { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient P { get; set; }
    }
}
