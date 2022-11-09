using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psychology.Core.Models;
using System;

namespace Psychology.Data.Configurations
{
    public class TestingAnswerConfiguration : IEntityTypeConfiguration<TestingAnswer>
    {
        public void Configure(EntityTypeBuilder<TestingAnswer> builder)
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
               .Property(m => m.TestingId)
               .IsRequired();

            builder
               .Property(m => m.AnswerId)
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
               .HasOne(m => m.Answer)
               .WithMany(m => m.TestingAnswers)
               .HasForeignKey(m => m.AnswerId);

            builder
               .HasOne(m => m.Testing)
               .WithMany(m => m.TestingAnswers)
               .HasForeignKey(m => m.TestingId);

            builder
                .ToTable("TestingAnswers");
        }
    }
}
