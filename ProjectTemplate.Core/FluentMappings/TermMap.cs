using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TermMap : EntityTypeConfiguration<Term>
    {
        public TermMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("Term");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.BeginDate).HasColumnName("BeginDate");
            Property(t => t.EndDate).HasColumnName("EndDate");
        }
    }
}
