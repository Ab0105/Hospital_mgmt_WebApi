using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class Lab
    {
        public Lab()
        {
            //InPatient = new HashSet<InPatient>();
            //Outpatient = new HashSet<Outpatient>();
            //RoomData = new HashSet<RoomData>();
        }

        public string LabId { get; set; }
        public string Pid { get; set; }
        public string DoctorId { get; set; }
        public DateTime TestDate { get; set; }
        public string TestType { get; set; }
        public string PatientType { get; set; }

        //public virtual Doctor Doctor { get; set; }
        //public virtual Patient P { get; set; }
        //public virtual ICollection<InPatient> InPatient { get; set; }
        //public virtual ICollection<Outpatient> Outpatient { get; set; }
        //public virtual ICollection<RoomData> RoomData { get; set; }
    }
}
