using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class TeacherLogModel
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        [Display(Name = "Değiştirilme Tarihi")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        
        [Display(Name = "Eğitmenler")]
        public ICollection<Employee> Teachers { get; set; }
    }
}