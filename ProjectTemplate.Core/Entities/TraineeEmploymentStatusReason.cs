using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class TraineeEmploymentStatusReason : Base
    {
        public TraineeEmploymentStatusReason()
        {
            TraineeEmploymentStatus = new List<TraineeEmploymentStatusReasonDetail>();
        }

        public string ReasonName { get; set; }

        public virtual ICollection<TraineeEmploymentStatusReasonDetail> TraineeEmploymentStatus { get; set; }

    }
}
