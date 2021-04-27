﻿// <auto-generated />
using System;
using InterviewTask.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InterviewTask.Core.Migrations
{
    [DbContext(typeof(WebDBContext))]
    partial class WebDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterviewTask.Core.Models.Answers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("InterviewTask.Core.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("InterviewTask.Core.Models.UserAnswers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AnswerDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AnswersID")
                        .HasColumnType("int");

                    b.Property<string>("UserLogin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AnswersID");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("InterviewTask.Core.Models.Answers", b =>
                {
                    b.HasOne("InterviewTask.Core.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionID");
                });

            modelBuilder.Entity("InterviewTask.Core.Models.UserAnswers", b =>
                {
                    b.HasOne("InterviewTask.Core.Models.Answers", "Answers")
                        .WithMany()
                        .HasForeignKey("AnswersID");
                });
#pragma warning restore 612, 618
        }
    }
}
