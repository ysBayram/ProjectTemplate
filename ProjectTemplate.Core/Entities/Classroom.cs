using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class Classroom:Base
    {
        public Classroom()
        {
            IskurClassrooms= new List<IskurClassroom>();
        }
        public string Name { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<IskurClassroom> IskurClassrooms { get; set; }
    }
}
