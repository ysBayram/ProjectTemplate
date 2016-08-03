using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class InterviewModel
    {
        [Display(Name = "Mülakat ID")]
        public int InterviewId { get; set; }
        [Display(Name = "Öğrenci ID")]
        public int StudentId { get; set; }
        [Display(Name = "Öğrenci Adı")]
        public string StudentFullName { get; set; }
        [Display(Name = "Mülakat Tarihi")]
        public DateTime Date { get; set; }
        [Display(Name = "Mülakat Durumu")]
        public int InterviewStateId { get; set; } //gitti-- gitmedi-- pozitif beklemede-- işe alındı 
        [Display(Name = "Mülakat Durumu")]
        public string InterviewStateName { get; set; }
        [Display(Name = "Mülakat Sonucu")]
        public string Result { get; set; }
        [Display(Name = "Firma Adı")]
        public int CompanyId { get; set; }
        [Display(Name = "Firma Adı")]
        public string CompanyName { get; set; }
        [Display(Name = "Mülakat Modeli")]
        public int ModelTypeId { get; set; }
        [Display(Name = "Mülakat Modeli")]
        public string ModelTypeName { get; set; }




        public List<Firm> Companies { get; set; }

        public List<Trainee> Students { get; set; }

        public List<TraineeStatus> InterviewStates { get; set; }

        public Dictionary<int, string> ModelTypes { get; set; }

    }
}

 

       
        
        
      