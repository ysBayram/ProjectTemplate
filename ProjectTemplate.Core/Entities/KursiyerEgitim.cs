using System;

namespace ProjectTemplate.Core.Entities
{
    public class KursiyerEgitim:Base
    {
        public int EducationId { get; set; }
        public int TraineeId { get; set; }
        public DateTime EducationBeginDate { get; set; }
        public DateTime EducationEndDate { get; set; }
        public int IskurClassroomId { get; set; }

        public virtual Education Education { get; set; }
        public virtual Trainee Trainee { get; set; }
        public virtual IskurClassroom IskurClassroom { get; set; }

    }
}
