﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsAPI.Data;

#nullable disable

namespace StudentsAPI.Migrations
{
    [DbContext(typeof(StudentsDBContext))]
    partial class StudentsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentsAPI.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Class", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "II"
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Score", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Marks = 90,
                            StudentId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Marks = 99,
                            StudentId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Marks = 100,
                            StudentId = 1,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            Marks = 85,
                            StudentId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 5,
                            Marks = 79,
                            StudentId = 1,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 6,
                            Marks = 79,
                            StudentId = 1,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 7,
                            Marks = 65,
                            StudentId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 8,
                            Marks = 75,
                            StudentId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 9,
                            Marks = 90,
                            StudentId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 10,
                            Marks = 85,
                            StudentId = 2,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 11,
                            Marks = 79,
                            StudentId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 12,
                            Marks = 79,
                            StudentId = 2,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 13,
                            Marks = 45,
                            StudentId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 14,
                            Marks = 65,
                            StudentId = 3,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 15,
                            Marks = 35,
                            StudentId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 16,
                            Marks = 55,
                            StudentId = 3,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 17,
                            Marks = 55,
                            StudentId = 3,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 18,
                            Marks = 79,
                            StudentId = 3,
                            SubjectId = 6
                        },
                        new
                        {
                            Id = 19,
                            Marks = 20,
                            StudentId = 4,
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 20,
                            Marks = 35,
                            StudentId = 4,
                            SubjectId = 2
                        },
                        new
                        {
                            Id = 21,
                            Marks = 45,
                            StudentId = 4,
                            SubjectId = 3
                        },
                        new
                        {
                            Id = 22,
                            Marks = 55,
                            StudentId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            Id = 23,
                            Marks = 65,
                            StudentId = 4,
                            SubjectId = 5
                        },
                        new
                        {
                            Id = 24,
                            Marks = 79,
                            StudentId = 4,
                            SubjectId = 6
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "115 Hill crest Avenue, Hyderabad.",
                            BirthDate = new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodGroup = "O +ve",
                            ClassId = 1,
                            Email = "ganesh@abc.com",
                            FatherName = "Ganesh Father",
                            FirstName = "Ganesh",
                            LastName = "K",
                            MotherName = "Ganesh Mother",
                            Phone = "1234567891",
                            RollNumber = "RN1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "2425 Matheson Blvd, Hyderabad.",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodGroup = "B +ve",
                            ClassId = 1,
                            Email = "suresh@abc.com",
                            FatherName = "Suresh Father",
                            FirstName = "Suresh",
                            LastName = "S",
                            MotherName = "Suresh Mother",
                            Phone = "1115556667",
                            RollNumber = "RN2"
                        },
                        new
                        {
                            Id = 3,
                            Address = "115 Hill crest Avenue, Hyderabad.",
                            BirthDate = new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodGroup = "O +ve",
                            ClassId = 1,
                            Email = "mahesh@abc.com",
                            FatherName = "Mahesh Father",
                            FirstName = "Mahesh",
                            MotherName = "Mahesh Mother",
                            Phone = "2225556667",
                            RollNumber = "RN3"
                        },
                        new
                        {
                            Id = 4,
                            Address = "115 Hill crest Avenue, Hyderabad.",
                            BirthDate = new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodGroup = "A +ve",
                            ClassId = 1,
                            Email = "mahesh@abc.com",
                            FatherName = "Ajar Father",
                            FirstName = "Ajar",
                            LastName = "Abbas",
                            MotherName = "Ajar Mother",
                            Phone = "9885412345",
                            RollNumber = "RN4"
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subject", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telugu"
                        },
                        new
                        {
                            Id = 2,
                            Name = "English"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hindi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "EVS"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ICT"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Maths"
                        });
                });

            modelBuilder.Entity("StudentsAPI.Models.Score", b =>
                {
                    b.HasOne("StudentsAPI.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsAPI.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentsAPI.Models.Student", b =>
                {
                    b.HasOne("StudentsAPI.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });
#pragma warning restore 612, 618
        }
    }
}
