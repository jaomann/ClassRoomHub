using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomHub.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>

    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("Entregas");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SubmissionDate).IsRequired();
            builder.Property(x => x.Score).IsRequired();
        }
    }
}
