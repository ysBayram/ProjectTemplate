using System;

namespace ProjectTemplate.Core.Entities
{
    public abstract class Person:Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TcIdentity { get; set; }
        public int CountyId { get; set; }
        public DateTime Birthdate { get; set; }
        public int Gender { get; set; }
        public bool Married { get; set; }
        public int SchoolId { get; set; }
        public int EducationLevelId { get; set; }
        public DateTime GraduationDate { get; set; }
        public int MilitaryState { get; set; }
        public DateTime MilitaryDefermentDate { get; set; }
        public DateTime MilitaryDischargeDate { get; set; }
        public bool DriverLicense { get; set; }

        //public virtual County County{ get; set; }
        //public virtual School School { get; set; }
        //public virtual EducationLevel EducationLevel{ get; set; }
        
        
    }
}
