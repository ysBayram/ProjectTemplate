using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class Education:Base
    {
        public Education()
        {
            KursiyerEğitims= new List<KursiyerEgitim>();
        }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual  ICollection<KursiyerEgitim> KursiyerEğitims { get; set; }
    }
}
