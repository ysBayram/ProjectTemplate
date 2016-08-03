using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("Department");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
