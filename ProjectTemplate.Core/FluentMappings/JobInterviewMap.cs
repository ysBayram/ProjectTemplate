using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class JobInterviewMap : EntityTypeConfiguration<JobInterview>
    {
        public JobInterviewMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Description)
                .HasMaxLength(250);


            // Table & Column Mappings
            ToTable("JobInterview");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Date).HasColumnName("Date");
            Property(t => t.FirmId).HasColumnName("FirmId");
            Property(t => t.InterviewStatusId).HasColumnName("InterviewStatusId");
            Property(t => t.ModelType).HasColumnName("ModelType");

            //// Relationships
            //HasRequired(t => t.Company)
            //    .WithMany(t => t.Interviews)
            //    .HasForeignKey(d => d.CompanyId);
            //HasRequired(t => t.InterviewState)
            //    .WithMany(t => t.Interviews)
            //    .HasForeignKey(d => d.InterviewStateId);
            //HasRequired(t => t.Student)
            //    .WithMany(t => t.Interviews)
            //    .HasForeignKey(d => d.StudentId);

        }
    }
}