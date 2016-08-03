using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
     public class IskurClassroom:Base
    {
         public int ClassroomId { get; set; }
         public string IskurCode { get; set; }
         public int TermId { get; set; }

         public virtual Classroom Classroom { get; set; }
         public virtual Term Term { get; set; }
         public virtual ICollection<KursiyerEgitim> KursiyerEğitims { get; set; }
    }
}
