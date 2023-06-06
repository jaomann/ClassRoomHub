using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(id => id.Id);
            builder.Property(CourseName => CourseName.Name).HasMaxLength(50).IsRequired();
            builder.Property(Description => Description.Description).HasMaxLength(400);

        }
    }
}
