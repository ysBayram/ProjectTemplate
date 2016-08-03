using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TraineeMap : EntityTypeConfiguration<Trainee>
    {

        /// <summary>
        /// Öğrenci entitisine gerekli attribute atamaları yapıldı
        ///     -İsim alanı zorunlu ve max 50 karakter olarak belirlendi
        ///     -Soy isim alanı zorunlu ve max 50 karakter olarak belirlendi
        ///     -Tc alanı zorunlu ve max 11 karakter olarak belirlendi
        ///     -Telefon alanı zorunlu ve max 50 karakter olarak belirlendi
        ///     -Email alanı zorunlu ve max 50 karakter olarak belirlendi
        ///     -
        /// </summary>
        public TraineeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.TcIdentity)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.FirstName)
               .IsRequired()
               .HasMaxLength(50);
            
            Property(t => t.LastName)
              .IsRequired()
              .HasMaxLength(50);

            Property(t => t.Phone)
             .IsRequired()
             .HasMaxLength(15);

            Property(t => t.Email)
            .IsRequired()
            .HasMaxLength(50);

            Property(t => t.ReservedFirmId)
                .IsOptional();

            Property(t => t.MilitaryDefermentDate)
                .IsOptional();

            Property(t => t.MilitaryDischargeDate)
                .IsOptional();

            //this.Property(t => t.TeacherId)
            //.IsRequired();

            // Table & Column Mappings
            ToTable("Trainee");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.TcIdentity).HasColumnName("TC");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.Phone).HasColumnName("Phone");
            Property(t => t.Email).HasColumnName("Email");
           // Property(t => t.EducationId).HasColumnName("EducationId");
           // Property(t => t.BranchId).HasColumnName("BranchId");
            Property(t => t.ReservedFirmId).HasColumnName("ReservedCompanyId");
            
            // Relationships
            //HasRequired(t => t.Education)
            //    .WithMany(t => t.Trainees)
            //    .HasForeignKey(d => d.EducationId);
            //HasRequired(t => t.Branch)
            //    .WithMany(t => t.Trainees)
            //    .HasForeignKey(d => d.BranchId);
            //HasOptional(t => t.Company)
            //    .WithMany(t => t.Students)
            //    .HasForeignKey(d => d.ReservedCompanyId);
            //HasRequired(t => t.Teacher)
            //    .WithMany(t => t.Students)
            //    .HasForeignKey(d => d.TeacherId);

        }
    }
}
