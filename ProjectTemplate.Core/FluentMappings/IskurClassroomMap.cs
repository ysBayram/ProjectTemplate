using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
    public class IskurClassroomMap : EntityTypeConfiguration<IskurClassroom>
    {
        public IskurClassroomMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("IskurClassroom");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.IskurCode).HasColumnName("IskurCode");
            Property(t => t.ClassroomId).HasColumnName("ClassroomId");
            Property(t => t.TermId).HasColumnName("TermId");
        }
    }
}
