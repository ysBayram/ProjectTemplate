using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class Firm : Base
    {
        /// <summary>
        /// Firma bilgilerinin tutulduğu entity
        ///   -Name, isim bilgilerinin tutulduğu yer.
        /// 
        ///  Navigation Property
        ///   -Interview entity ile bire çok ilişkisi var.  
        /// </summary>


        public Firm()
        {
            JobInterviews = new List<JobInterview>();
            Trainees= new List<Trainee>();
        }

      
        public string Name { get; set; }

        public virtual ICollection<JobInterview> JobInterviews { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}

