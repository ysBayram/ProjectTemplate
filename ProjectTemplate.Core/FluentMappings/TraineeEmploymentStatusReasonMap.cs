using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TraineeEmploymentStatusReasonMap : EntityTypeConfiguration<TraineeEmploymentStatusReason>
    {
        public TraineeEmploymentStatusReasonMap ()
        {
            HasKey(t => t.Id);


            Property(t => t.ReasonName)
               .IsRequired().HasMaxLength(50);

	}
      
    }
}
