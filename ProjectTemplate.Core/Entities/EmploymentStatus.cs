using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class EmploymentStatus : Base
    {
        public EmploymentStatus()
        {
            StudentWorkStateDetails = new List<TraineeEmploymentStatus>();
        }
        public string Name { get; set; }

        public virtual ICollection<TraineeEmploymentStatus> StudentWorkStateDetails { get; set; }
    }
}
