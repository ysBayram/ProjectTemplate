using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class TraineeStatus : Base
    {
        public TraineeStatus()
        {
            Interviews = new List<JobInterview>();
        }

        public string Name { get; set; }

        public virtual ICollection<JobInterview> Interviews { get; set; }
    }
}
