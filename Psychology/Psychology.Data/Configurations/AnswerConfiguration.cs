using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Psychology.Core.Models;
using System;

namespace Psychology.Data.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
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
               .HasOne(m => m.Question)
               .WithMany(m => m.Answers)
               .HasForeignKey(m => m.QuestionId);

            builder
            .HasData(
            #region Question 1
                new Answer
                {
                    Id = 10001,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Don’t dare to interrupt them",
                    QuestionId = 10001,
                    PercentageIntrovert = 70
                },
                new Answer
                {
                    Id = 10002,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Think it’s more important to give them some of your time; work can wait",
                    QuestionId = 10001,
                    PercentageIntrovert = 20
                },
                new Answer
                {
                    Id = 10003,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Listen, but with only with half an ear",
                    QuestionId = 10001,
                    PercentageIntrovert = 56
                },
                new Answer
                {
                    Id = 10004,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Interrupt and explain that you are really busy at the moment",
                    QuestionId = 10001,
                    PercentageIntrovert = 40
                },
                #endregion

            #region Question 2
                new Answer
                {
                    Id = 10005,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Look at your watch every two minutes",
                    QuestionId = 10002,
                    PercentageIntrovert = 30
                },
                new Answer
                {
                    Id = 10006,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Bubble with inner anger, but keep quiet",
                    QuestionId = 10002,
                    PercentageIntrovert = 90
                },
                new Answer
                {
                    Id = 10007,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Explain to other equally impatient people in the room that the doctor is always running late",
                    QuestionId = 10002,
                    PercentageIntrovert = 58
                },
                new Answer
                {
                    Id = 10008,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Complain in a loud voice, while tapping your foot impatiently",
                    QuestionId = 10002,
                    PercentageIntrovert = 25
                },
                #endregion

            #region Question 3
                new Answer
                {
                    Id = 10009,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Don’t dare contradict them",
                    QuestionId = 10003,
                    PercentageIntrovert = 67
                },
                new Answer
                {
                    Id = 10010,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Think that they are obviously right",
                    QuestionId = 10003,
                    PercentageIntrovert = 55
                },
                new Answer
                {
                    Id = 10011,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Defend your own point of view, tooth and nail",
                    QuestionId = 10003,
                    PercentageIntrovert = 32
                },
                new Answer
                {
                    Id = 10012,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Continuously interrupt your colleague",
                    QuestionId = 10003,
                    PercentageIntrovert = 27
                },
                #endregion

            #region Question 4
                new Answer
                {
                    Id = 10013,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Are a bit too far towards the back so don’t really hear what the guide is saying",
                    QuestionId = 10004,
                    PercentageIntrovert = 55
                },
                new Answer
                {
                    Id = 10014,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Follow the group without question",
                    QuestionId = 10004,
                    PercentageIntrovert = 76
                },
                new Answer
                {
                    Id = 10015,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Make sure that everyone is able to hear properly",
                    QuestionId = 10004,
                    PercentageIntrovert = 55
                },
                new Answer
                {
                    Id = 10016,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Are right up the front, adding your own comments in a loud voice",
                    QuestionId = 10004,
                    PercentageIntrovert = 20
                },
            #endregion

            #region Question 5
                new Answer
                {
                    Id = 10017,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Ask you to tell a story in front of everyone else",
                    QuestionId = 10005,
                    PercentageIntrovert = 71
                },
                new Answer
                {
                    Id = 10018,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Talk privately between themselves",
                    QuestionId = 10005,
                    PercentageIntrovert = 34
                },
                new Answer
                {
                    Id = 10019,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Hang around you all evening",
                    QuestionId = 10005,
                    PercentageIntrovert = 78
                },
                new Answer
                {
                    Id = 10020,
                    CreatedBy = "System",
                    CreatedDate = DateTime.MinValue,
                    ModifiedDate = DateTime.MinValue,
                    Description = "Always drag the conversation back to themselves",
                    QuestionId = 10005,
                    PercentageIntrovert = 20
                }
                #endregion
            );

            builder
                .ToTable("Answers");
        }
    }
}
