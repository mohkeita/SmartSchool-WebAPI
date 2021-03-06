﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool_WebAPI.Data;

namespace SmartSchool_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201104135348_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            id = 1,
                            firstname = "Marta",
                            lastname = "Kent",
                            phone = "33225555"
                        },
                        new
                        {
                            id = 2,
                            firstname = "Paula",
                            lastname = "Isabela",
                            phone = "3354288"
                        },
                        new
                        {
                            id = 3,
                            firstname = "Laura",
                            lastname = "Antonia",
                            phone = "55668899"
                        },
                        new
                        {
                            id = 4,
                            firstname = "Luiza",
                            lastname = "Maria",
                            phone = "6565659"
                        },
                        new
                        {
                            id = 5,
                            firstname = "Lucas",
                            lastname = "Machado",
                            phone = "565685415"
                        },
                        new
                        {
                            id = 6,
                            firstname = "Pedro",
                            lastname = "Alvares",
                            phone = "456454545"
                        },
                        new
                        {
                            id = 7,
                            firstname = "Paulo",
                            lastname = "José",
                            phone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentsSubject");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 1,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 2
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 3
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            SubjectId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mathematique",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physique",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Francais",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Anglais",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Programmation",
                            TeacherId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Teacher", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            name = "Lauro"
                        },
                        new
                        {
                            id = 2,
                            name = "Roberto"
                        },
                        new
                        {
                            id = 3,
                            name = "Ronaldo"
                        },
                        new
                        {
                            id = 4,
                            name = "Rodrigo"
                        },
                        new
                        {
                            id = 5,
                            name = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.StudentSubject", b =>
                {
                    b.HasOne("SmartSchool_WebAPI.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool_WebAPI.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Subject", b =>
                {
                    b.HasOne("SmartSchool_WebAPI.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
