using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
    public class EmployeeTypeMap : EntityTypeConfiguration<EmployeeType>
    {
        public EmployeeTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("EmployeeType");

            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
