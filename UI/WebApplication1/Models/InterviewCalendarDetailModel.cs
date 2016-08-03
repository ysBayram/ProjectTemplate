using System;

namespace WebApplication1.Models
{
    public class InterviewCalendarDetailModel
    {
        public int InterviewId { get; set; }
        public string StudentFullName { get; set; }
        public DateTime Date { get; set; }
        public string InterviewStateName { get; set; }
        public string Result { get; set; }
        public string CompanyName { get; set; }
        public string ModelTypeName { get; set; }
    }
}