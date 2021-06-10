﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial02;

namespace Parcial02.Migrations
{
    [DbContext(typeof(AdmissionsContext))]
    [Migration("20210609061709_Change2")]
    partial class Change2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parcial02.Entities.Faculty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("faculty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("faculties");

                    b.HasData(
                        new
                        {
                            id = 1,
                            faculty = "Architecture and Engineering"
                        },
                        new
                        {
                            id = 2,
                            faculty = "Social Sciences and Humanities"
                        },
                        new
                        {
                            id = 3,
                            faculty = "Economic and Business Sciences"
                        });
                });

            modelBuilder.Entity("Parcial02.Entities.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("facultyid")
                        .HasColumnType("int");

                    b.Property<int?>("usercardID")
                        .HasColumnType("int");

                    b.Property<bool>("vigent")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("facultyid");

                    b.HasIndex("usercardID");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("Parcial02.Entities.SecurityQuestion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("securityQuestions");

                    b.HasData(
                        new
                        {
                            id = 1,
                            question = "What year were you born?"
                        },
                        new
                        {
                            id = 2,
                            question = "What was your first pet's name?"
                        },
                        new
                        {
                            id = 3,
                            question = "What college did you graduate from?"
                        },
                        new
                        {
                            id = 4,
                            question = "What's your favorite movie's name?"
                        });
                });

            modelBuilder.Entity("Parcial02.Entities.User", b =>
                {
                    b.Property<int>("cardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("securityQuestionid")
                        .HasColumnType("int");

                    b.HasKey("cardID");

                    b.HasIndex("securityQuestionid");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Parcial02.Entities.Request", b =>
                {
                    b.HasOne("Parcial02.Entities.Faculty", "faculty")
                        .WithMany()
                        .HasForeignKey("facultyid");

                    b.HasOne("Parcial02.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("usercardID");

                    b.Navigation("faculty");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Parcial02.Entities.User", b =>
                {
                    b.HasOne("Parcial02.Entities.SecurityQuestion", "securityQuestion")
                        .WithMany()
                        .HasForeignKey("securityQuestionid");

                    b.Navigation("securityQuestion");
                });
#pragma warning restore 612, 618
        }
    }
}
