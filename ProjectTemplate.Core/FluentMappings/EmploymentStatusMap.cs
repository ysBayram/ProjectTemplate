using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class EmploymentStatusMap : EntityTypeConfiguration<EmploymentStatus>
    {
        public EmploymentStatusMap()
        {
            HasKey(t => t.Id);

            // Özellikler belirlendi
            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Name kolonu 60 karakterlik  ve gerekli olarak belirlendi
            Property(t => t.Name)
                .HasMaxLength(60)
                .IsRequired();

            // Table & Column Mappings
            ToTable("EmploymentStatus");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");


          

            
        }
    }
}
