using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class EmployeeType:Base
    {
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees  { get; set; }
    }
}
