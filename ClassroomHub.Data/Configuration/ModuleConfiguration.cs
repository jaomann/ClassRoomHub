using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    public class ModuleConfiguration : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Module");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.Start).IsRequired(); 
            builder.Property(x => x.End).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.Module).HasForeignKey(x => x.TeacherId) ;

        }
    }
}
