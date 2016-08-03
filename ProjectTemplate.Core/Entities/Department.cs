using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
   public class Department : Base
    {
       public Department()
       {
           Educations=new List<Education>();
       }
       public string Name { get; set; }

       public virtual ICollection<Education> Educations { get; set; }

    }
}
