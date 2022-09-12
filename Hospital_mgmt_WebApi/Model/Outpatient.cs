using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class Outpatient
    {
        public string Pid { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string DoctorId { get; set; }
        public string LabId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Lab Lab { get; set; }
    }
}
