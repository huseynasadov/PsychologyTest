using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psychology.Core.Models;
using System;

namespace Psychology.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
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
                .Property(m => m.Description)
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
            .HasData(
                new Question
                {
                    Id = 10001,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "You’re really busy at work and a colleague is telling you their life story and personal woes. You:"
                },
                new Question
                {
                    Id = 10002,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:"
                },
                new Question
                {
                    Id = 10003,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:"
                },
                new Question
                {
                    Id = 10004,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "You are taking part in a guided tour of a museum. You:"
                },
                new Question
                {
                    Id = 10005,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "During dinner parties at your home, you have a hard time with people who:"
                }
            );

            builder
                .ToTable("Questions");
        }
    }
}
