using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class DataTypeEnt : Base
    {
        /// <summary>
        /// Veri tiplerinin tutulduğu entity
        ///   -Name, isim bilgilerinin tutulduğu yer.
        /// 
        ///  Navigation Property
        ///   -StudentWorkStateDetail entity ile bire çok ilişkisi var.  
        /// </summary>

        public DataTypeEnt()
        {
            TraineeEmploymentStatus = new List<TraineeEmploymentStatus>();
        }
        public string Name { get; set; }

        public virtual ICollection<TraineeEmploymentStatus> TraineeEmploymentStatus { get; set; }
    }
}
