using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Core.Entities
{
    public class Employee:Person
    {
        public int EmployeeTypeId { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
    }
}
