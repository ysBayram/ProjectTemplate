using System;
using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class Term:Base
    {
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<IskurClassroom> IskurClassrooms { get; set; }
        }
}
