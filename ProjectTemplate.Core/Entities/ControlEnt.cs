using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class ControlEnt : Base
    {
        /// <summary>
        /// Kontrollerin tutulduğu entity
        ///   -Name, isim bilgilerinin tutulduğu yer.
        /// 
        ///  Navigation Property
        ///   -StudentWorkStateDetail entity ile bire çok ilişkisi var.  
        /// </summary>
        public ControlEnt()
        {
            TraineeEmploymentStatus = new List<TraineeEmploymentStatus>();
        }
        public string Name { get; set; }
        public virtual ICollection<TraineeEmploymentStatus> TraineeEmploymentStatus { get; set; }
    }
}
