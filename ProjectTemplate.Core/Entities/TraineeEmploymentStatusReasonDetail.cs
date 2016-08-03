using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class TraineeEmploymentStatusReasonDetail : Base
    {
        public int StateId { get; set; }
        public int ReasonId { get; set; }

        public virtual TraineeEmploymentStatusReason Reason { get; set; }
        public virtual EmploymentStatus State { get; set; }

    }
}
