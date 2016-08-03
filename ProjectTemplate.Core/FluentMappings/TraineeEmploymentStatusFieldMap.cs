using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TraineeEmploymentStatusFieldMap: EntityTypeConfiguration<TraineeEmploymentStatusField>
    {
        public TraineeEmploymentStatusFieldMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StudentWorkStateFields");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
