using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class TraineeEmploymentStatusReasonDetailMap : EntityTypeConfiguration<TraineeEmploymentStatusReasonDetail>
   {
       public TraineeEmploymentStatusReasonDetailMap()
       {
           HasKey(t => t.Id);

           Property(t => t.ReasonId)
             .IsRequired();
           Property(t => t.StateId)
             .IsRequired();
       }


    }
}
