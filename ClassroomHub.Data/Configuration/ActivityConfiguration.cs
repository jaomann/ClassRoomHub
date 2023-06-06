using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
    internal class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Atividade");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.DueDate).IsRequired();
            builder.Property(x => x.GradePoints).IsRequired();
            builder.HasOne(x => x.Teacher).WithOne(x => x.Activity);
            builder.HasOne(x => x.Module).WithMany(x => x.Activity);
        }
    }
}
