using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class Doctor
    {
        public Doctor()
        {
            //BillData = new HashSet<BillData>();
            //InPatient = new HashSet<InPatient>();
            //Lab = new HashSet<Lab>();
            //Outpatient = new HashSet<Outpatient>();
            //Patient = new HashSet<Patient>();
            //RoomData = new HashSet<RoomData>();
        }

        public string DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Dept { get; set; }

        //public virtual ICollection<BillData> BillData { get; set; }
        //public virtual ICollection<InPatient> InPatient { get; set; }
        //public virtual ICollection<Lab> Lab { get; set; }
        //public virtual ICollection<Outpatient> Outpatient { get; set; }
        //public virtual ICollection<Patient> Patient { get; set; }
        //public virtual ICollection<RoomData> RoomData { get; set; }
    }
}
