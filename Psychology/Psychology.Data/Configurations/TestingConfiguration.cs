using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psychology.Core.Models;
using System;

namespace Psychology.Data.Configurations
{
    public class TestingConfiguration : IEntityTypeConfiguration<Testing>
    {
        public void Configure(EntityTypeBuilder<Testing> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
               .Property(m => m.Status)
               .IsRequired()
               .HasDefaultValue(true);

            builder
              .Property(m => m.PersentageIntrovert)
              .IsRequired();

            builder
              .Property(m => m.PercentageExtrovert)
              .IsRequired();

            builder
              .Property(m => m.QuestionCount)
              .IsRequired();

            builder
               .Property(m => m.ModifiedBy)
               .HasMaxLength(100);

            builder
               .Property(m => m.CreatedBy)
               .HasMaxLength(100);

            builder
               .Property(m => m.CreatedDate)
               .HasDefaultValue(DateTime.Now);

            builder
              .Property(m => m.ModifiedDate)
              .HasDefaultValue(DateTime.Now);

            builder
                .ToTable("Testings");
        }
    }
}
