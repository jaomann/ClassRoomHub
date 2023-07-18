using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
    internal class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Turmas");
            builder.HasKey(id => id.Id);
            builder.Property(Name => Name.Name).IsRequired();
            builder.Property(Start => Start.Start).IsRequired() ;
            builder.Property(End => End.End).IsRequired();
            builder.HasOne(x => x.Course).WithMany(x => x.Classes).HasForeignKey(x => x.CourseId);
            builder.HasMany(x => x.Students).WithOne(x => x.Class).HasForeignKey(x => x.ClassId);
        }
    }
}
