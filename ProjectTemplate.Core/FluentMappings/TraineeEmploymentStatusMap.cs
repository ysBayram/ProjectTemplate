using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TraineeEmploymentStatusMap : EntityTypeConfiguration<TraineeEmploymentStatus>
    {
        public TraineeEmploymentStatusMap()
        {

            HasKey(t => t.Id);

            // Özellikler belirlendi
            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Name kolonu 60 karakterlik  ve gerekli olarak belirlendi
            Property(t => t.StateFieldId)
                .IsRequired();

            Property(t => t.StateFieldValue)
                .IsRequired();

            Property(t => t.WorkStateId)
                .IsRequired();

            Property(t => t.TraineeId)
                .IsRequired();

            Property(t => t.DataTypeId)
                .IsRequired();

            Property(t => t.ControlId)
                .IsRequired();


            // Table & Column Mappings
            ToTable("TraineeEmploymentStatus");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.StateFieldId).HasColumnName("StateFieldId");
            Property(t => t.StateFieldValue).HasColumnName("StateFieldValue");
            Property(t => t.WorkStateId).HasColumnName("WorkStateId");
            Property(t => t.TraineeId).HasColumnName("TraineeId");
            Property(t => t.DataTypeId).HasColumnName("DataTypeId");
            Property(t => t.ControlId).HasColumnName("ControlId");


            //// Relationships
            //HasRequired(t => t.StudentWorkState)
            //    .WithMany(t => t.StudentWorkStateDetails)
            //    .HasForeignKey(d => d.WorkStateId);
            ////HasRequired(t => t.Student)
            ////    .WithMany(t => t.StudentWorkStateDetails)
            ////    .HasForeignKey(d => d.StudentId);

            //HasRequired(t => t.StudentWorkStateField)
            //    .WithMany(t => t.StudentWorkStateDetails)
            //    .HasForeignKey(d => d.StateFieldId);
            //HasRequired(t => t.DataType)
            //    .WithMany(t => t.StudentWorkStateDetails)
            //    .HasForeignKey(d => d.DataTypeId);
            //HasRequired(t => t.Control)
            //    .WithMany(t => t.StudentWorkStateDetails)
            //    .HasForeignKey(d => d.ControlId);
        
        }
    }
}
