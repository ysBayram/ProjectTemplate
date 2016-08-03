using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class StudentInterviewModel
    {
        public int Id { get; set; }

        public string IdentityNumber { get; set; }

        public string FullName { get; set; }

        public string TeacherFullName { get; set; }

        public string BranchName { get; set; }

        public string IskurClass { get; set; }

        public string EducationName { get; set; }

        public string StudentWorkState { get; set; }

        public string StateDescription { get; set; }

        public DateTime? LastInterviewDate { get; set; }

        public string ReserverdCompanyName { get; set; }

        public List<JobInterview> Interviews { get; set; }
    }
}