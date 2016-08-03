using System;

namespace ProjectTemplate.Core.Entities
{
    public class JobInterview : Base
    {
        public int TraineeId { get; set; }
        public int FirmId { get; set; }
        public int InterviewStatusId { get; set; }
        public int ModelType { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual TraineeStatus InterviewStatus { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}