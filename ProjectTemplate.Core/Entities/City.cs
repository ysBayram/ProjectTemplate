using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class City:Base
    {
        public string Name { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
