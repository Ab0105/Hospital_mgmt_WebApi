using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public string Pid { get; set; }
        public string DoctorName { get; set; }
        public string RoomNo { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string Remarks { get; set; }

        //public virtual Patient P { get; set; }
        //public virtual RoomData RoomNoNavigation { get; set; }
    }
}
