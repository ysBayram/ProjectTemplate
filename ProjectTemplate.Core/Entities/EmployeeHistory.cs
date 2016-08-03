using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Core.Entities
{
    public class EmployeeHistory:Base
    {
        public int EmployeeId { get; set; }
        public int TraineeId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public virtual Trainee Trainee { get; set; }
        public virtual Employee Employee{ get; set; }
    }
}
