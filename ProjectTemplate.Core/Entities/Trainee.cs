using System;
using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class Trainee : Person
    {
        

        public Trainee()
        {
            Interviews = new List<JobInterview>();
            EmployeeHistories= new List<EmployeeHistory>();
        }

        public DateTime EmploymentStartDate { get; set; }
        public int ReservedFirmId { get; set; }

        //public virtual Education Education { get; set; }
        public virtual ICollection<JobInterview> Interviews { get; set; }
        public virtual Firm ReservedFirm { get; set; }
        //public virtual ICollection<StudentWorkStateDetailEnt> StudentWorkStateDetails { get; set; } traineehistory olacak
        public virtual ICollection<EmployeeHistory> EmployeeHistories { get; set; }
        public virtual ICollection<KursiyerEgitim> KursiyerEğitims { get; set; }
       

    }
}
