using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("City");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
