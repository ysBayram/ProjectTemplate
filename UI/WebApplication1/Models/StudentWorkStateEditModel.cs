using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class StudentWorkStateEditModel
    {

        [Display(Name = "Değiştirilme Tarihi")]
        public DateTime ModifiedDate { get; set; }

        public int StudentId { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Display(Name = "Başlama Tarihi")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
        
        [Display(Name = "Firma")]
        public ICollection<Firm> Firms { get; set; }

        [Display(Name = "İş Durumu")]
        public ICollection<EmploymentStatus> EmploymentStatus { get; set; }

        [Display(Name = "İş Durumu Sebebi")]
        public ICollection<TraineeEmploymentStatusReason> TraineeEmploymentStatusReason { get; set; }

    }
}