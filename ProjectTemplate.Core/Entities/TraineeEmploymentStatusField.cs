using System.Collections.Generic;

namespace ProjectTemplate.Core.Entities
{
    public class TraineeEmploymentStatusField : Base
    {
        /// <summary>
        /// Durum sebeplerinin içindeki alanların tutulduğu entity
        ///   -Name, isim bilgilerinin tutulduğu yer.
        /// 
        ///  Navigation Property
        ///   -StudentWorkStateDetail entity ile bire çok ilişkisi var.  
        /// </summary>
        public TraineeEmploymentStatusField()
        {
            TraineeEmploymentStatus = new List<TraineeEmploymentStatus>();
        }
        public string Name { get; set; }

        public virtual ICollection<TraineeEmploymentStatus> TraineeEmploymentStatus { get; set; }
    }
}
