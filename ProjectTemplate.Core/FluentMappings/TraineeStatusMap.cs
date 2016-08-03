﻿using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class TraineeStatusMap : EntityTypeConfiguration<TraineeStatus>
    {
        public TraineeStatusMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TraineeStatus");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
