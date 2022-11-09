﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Psychology.Data;

namespace Psychology.Data.Migrations
{
    [DbContext(typeof(PsychologyDbContext))]
    [Migration("20221109143208_idschanged")]
    partial class idschanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Psychology.Core.Models.Admin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("AdminStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)3);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 190, DateTimeKind.Local).AddTicks(722));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fullname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InvitedToken")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 191, DateTimeKind.Local).AddTicks(3800));

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilePhoto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Token")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 9223372036854775807L,
                            AdminStatus = (byte)1,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            Fullname = "Admin",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "AQAAAAEAACcQAAAAEP1jT0liAVocRr8oJm4awSC2V2sFg4WM1JCt2lz71ip5nekLZxHZXI/piFp4F7gKvA==",
                            Status = false,
                            Token = "1f22ef45-fa82-4b1e-a2ba-4e51c0f1e761"
                        });
                });

            modelBuilder.Entity("Psychology.Core.Models.Answer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4219));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 209, DateTimeKind.Local).AddTicks(4974));

                    b.Property<int>("PercentageIntrovert")
                        .HasColumnType("int");

                    b.Property<long>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 9223372036854765806L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Don’t dare to interrupt them",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 70,
                            QuestionId = 9223372036854765806L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765805L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Think it’s more important to give them some of your time; work can wait",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 20,
                            QuestionId = 9223372036854765806L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765804L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Listen, but with only with half an ear",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 56,
                            QuestionId = 9223372036854765806L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765803L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Interrupt and explain that you are really busy at the moment",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 40,
                            QuestionId = 9223372036854765806L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765802L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Look at your watch every two minutes",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 30,
                            QuestionId = 9223372036854765805L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765801L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bubble with inner anger, but keep quiet",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 90,
                            QuestionId = 9223372036854765805L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765800L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Explain to other equally impatient people in the room that the doctor is always running late",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 58,
                            QuestionId = 9223372036854765805L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765799L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Complain in a loud voice, while tapping your foot impatiently",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 25,
                            QuestionId = 9223372036854765805L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765798L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Don’t dare contradict them",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 67,
                            QuestionId = 9223372036854765804L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765797L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Think that they are obviously right",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 55,
                            QuestionId = 9223372036854765804L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765796L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Defend your own point of view, tooth and nail",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 32,
                            QuestionId = 9223372036854765804L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765795L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Continuously interrupt your colleague",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 27,
                            QuestionId = 9223372036854765804L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765794L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Are a bit too far towards the back so don’t really hear what the guide is saying",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 55,
                            QuestionId = 9223372036854765803L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765793L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Follow the group without question",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 76,
                            QuestionId = 9223372036854765803L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765792L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Make sure that everyone is able to hear properly",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 55,
                            QuestionId = 9223372036854765803L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765791L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Are right up the front, adding your own comments in a loud voice",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 20,
                            QuestionId = 9223372036854765803L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765790L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ask you to tell a story in front of everyone else",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 71,
                            QuestionId = 9223372036854765802L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765789L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Talk privately between themselves",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 34,
                            QuestionId = 9223372036854765802L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765788L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hang around you all evening",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 78,
                            QuestionId = 9223372036854765802L,
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765787L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Always drag the conversation back to themselves",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PercentageIntrovert = 20,
                            QuestionId = 9223372036854765802L,
                            Status = false
                        });
                });

            modelBuilder.Entity("Psychology.Core.Models.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6193));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 206, DateTimeKind.Local).AddTicks(6585));

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 9223372036854765806L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You’re really busy at work and a colleague is telling you their life story and personal woes. You:",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765805L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You’ve been sitting in the doctor’s waiting room for more than 25 minutes. You:",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765804L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You’re having an animated discussion with a colleague regarding a project that you’re in charge of. You:",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765803L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You are taking part in a guided tour of a museum. You:",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        },
                        new
                        {
                            Id = 9223372036854765802L,
                            CreatedBy = "System",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "During dinner parties at your home, you have a hard time with people who:",
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = false
                        });
                });

            modelBuilder.Entity("Psychology.Core.Models.Testing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(946));

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 214, DateTimeKind.Local).AddTicks(1404));

                    b.Property<int>("PercentageExtrovert")
                        .HasColumnType("int");

                    b.Property<int>("PersentageIntrovert")
                        .HasColumnType("int");

                    b.Property<int>("QuestionCount")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Testings");
                });

            modelBuilder.Entity("Psychology.Core.Models.TestingAnswer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AnswerId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 215, DateTimeKind.Local).AddTicks(9704));

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 9, 18, 32, 8, 216, DateTimeKind.Local).AddTicks(95));

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<long>("TestingId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("TestingId");

                    b.ToTable("TestingAnswers");
                });

            modelBuilder.Entity("Psychology.Core.Models.Answer", b =>
                {
                    b.HasOne("Psychology.Core.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Psychology.Core.Models.TestingAnswer", b =>
                {
                    b.HasOne("Psychology.Core.Models.Answer", "Answer")
                        .WithMany("TestingAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Psychology.Core.Models.Testing", "Testing")
                        .WithMany("TestingAnswers")
                        .HasForeignKey("TestingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Testing");
                });

            modelBuilder.Entity("Psychology.Core.Models.Answer", b =>
                {
                    b.Navigation("TestingAnswers");
                });

            modelBuilder.Entity("Psychology.Core.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Psychology.Core.Models.Testing", b =>
                {
                    b.Navigation("TestingAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
