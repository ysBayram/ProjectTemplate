using System;
using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class TraineeEmploymentStatus : Base
    {
        public int StateFieldId { get; set; }

        public string StateFieldValue { get; set; }

        public int WorkStateId { get; set; }

        public int TraineeId { get; set; }

        public int DataTypeId { get; set; }

        public int ControlId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        // Navigation
        public virtual EmploymentStatus WorkState { get; set; }

        public virtual Trainee Trainee { get; set; }

        public virtual TraineeEmploymentStatusField StateField { get; set; }

        public virtual DataTypeEnt DataType { get; set; }

        public virtual ControlEnt Control { get; set; }
    }
}
