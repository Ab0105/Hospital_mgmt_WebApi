using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class InPatient
    {
        public string Pid { get; set; }
        public string RoomNo { get; set; }
        public string DoctorId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string LabId { get; set; }
        public decimal AmountPerDay { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Lab Lab { get; set; }
        public virtual RoomData RoomNoNavigation { get; set; }
    }
}
