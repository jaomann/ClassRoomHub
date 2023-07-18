using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
