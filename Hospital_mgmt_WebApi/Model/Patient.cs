using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hospital_mgmt_WebApi.Model
{
    public partial class Patient
    {
        public Patient()
        {
            //BillData = new HashSet<BillData>();
            //Lab = new HashSet<Lab>();
        }

        public string Pid { get; set; }
        public string Name { get; set; }
        public decimal Age { get; set; }
        public decimal Weight { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public decimal PhoneNo { get; set; }
        public string Disease { get; set; }
        public string DoctorId { get; set; }

        //public virtual Doctor Doctor { get; set; }
        //public virtual ICollection<BillData> BillData { get; set; }
        //public virtual ICollection<Lab> Lab { get; set; }
    }
}
