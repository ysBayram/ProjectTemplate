using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class EmployeeHistoryMap : EntityTypeConfiguration<EmployeeHistory>
    {
        public EmployeeHistoryMap()
        {

            // Primary Key
            HasKey(t => t.Id);

            // Table & Column Mappings
            ToTable("EmployeeHistory");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            Property(t => t.Date).HasColumnName("Date");
            Property(t => t.EmployeeId).HasColumnName("TeacherId");
            Property(t => t.TraineeId).HasColumnName("StudentId");
            Property(t => t.Description).HasColumnName("Description");

            Property(t => t.Description).IsRequired().HasMaxLength(200);


            // Relationships
            //this.HasRequired(t => t.Teacher)
            //    .WithMany(t => t.TeacherLogs)
            //    .HasForeignKey(d => d.TeacherId)
            //    .WillCascadeOnDelete(false);

            //this.HasRequired(t => t.Student)
            //    .WithMany(t => t.TeacherLogs)
            //    .HasForeignKey(d => d.StudentId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
