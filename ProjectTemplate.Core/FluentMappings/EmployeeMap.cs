using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
       public EmployeeMap()
       {
           HasKey(t => t.Id);

           Property(t => t.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           Property(t => t.FirstName)
              .IsRequired()
              .HasMaxLength(50);

           Property(t => t.LastName)
              .IsRequired()
              .HasMaxLength(50);

           Property(t => t.EmployeeTypeId)
              .IsRequired();

           // Table & Column Mappings
           ToTable("Employee");
           Property(t => t.Id).HasColumnName("Id");
           Property(t => t.FirstName).HasColumnName("FirstName");
           Property(t => t.LastName).HasColumnName("LastName");
           Property(t => t.EmployeeTypeId).HasColumnName("EmployeeTypeId");
       }
    }
}
