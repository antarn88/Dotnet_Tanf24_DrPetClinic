﻿// <auto-generated />
using System;
using DrPetClinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrPetClinic.Data.Migrations
{
    [DbContext(typeof(DrPetClinicDBContext))]
    partial class DrPetClinicDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimalPerson", b =>
                {
                    b.Property<Guid>("AnimalsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OwnersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimalsId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("AnimalPerson");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d4ad174-8291-4747-a198-b8a9b774b2d5"),
                            BirthDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ő a falu legszorgalmasabb terelője.",
                            Name = "Bodri",
                            Species = "Kutya",
                            Status = "Jó egészségnek örvend",
                            Type = "Puli"
                        },
                        new
                        {
                            Id = new Guid("085e3d10-4f4f-4df6-863f-3277a5966a50"),
                            BirthDate = new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A kajáért él-hal, de csak akkor enged közel, ha akar.",
                            Name = "Cirmi",
                            Species = "Macska",
                            Status = "Kissé morcos",
                            Type = "Sziámi"
                        });
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.ConsultationTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<byte>("Month")
                        .HasMaxLength(12)
                        .HasColumnType("tinyint");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<byte>("Week")
                        .HasMaxLength(53)
                        .HasColumnType("tinyint");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ConsultationTimes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eeff6bd6-ace8-4b53-9883-68d5cebb73f8"),
                            DayOfWeek = 1,
                            Description = "Általános rendelési idő hétfőn.",
                            EmployeeId = new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"),
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)11,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            Week = (byte)1,
                            Year = (short)2024
                        },
                        new
                        {
                            Id = new Guid("ece94967-6c2d-4eab-8a3d-046a52bebe45"),
                            DayOfWeek = 2,
                            Description = "Általános rendelési idő kedden.",
                            EmployeeId = new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)11,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            Week = (byte)2,
                            Year = (short)2024
                        },
                        new
                        {
                            Id = new Guid("8245fd30-426b-479e-ba1b-75708102adfe"),
                            DayOfWeek = 4,
                            Description = "Csütörtöki rendelés.",
                            EmployeeId = new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"),
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)11,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0),
                            Week = (byte)3,
                            Year = (short)2024
                        },
                        new
                        {
                            Id = new Guid("b382828d-c2c9-4cab-a8e8-741b90af273c"),
                            DayOfWeek = 3,
                            Description = "Szerdai rendelés.",
                            EmployeeId = new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"),
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)12,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0),
                            Week = (byte)1,
                            Year = (short)2024
                        },
                        new
                        {
                            Id = new Guid("3b6b0e08-a8b0-446a-ace1-67d892eb9e2a"),
                            DayOfWeek = 5,
                            Description = "Pénteki rendelés.",
                            EmployeeId = new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"),
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)12,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            Week = (byte)2,
                            Year = (short)2024
                        },
                        new
                        {
                            Id = new Guid("bf47ede7-3754-4f79-982c-58d71f84c52b"),
                            DayOfWeek = 1,
                            Description = "Hétfői rendelés.",
                            EmployeeId = new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)12,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            Week = (byte)3,
                            Year = (short)2024
                        });
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"),
                            Description = "Szakértő állatorvos.",
                            Name = "Dr. Vakarcs Pál",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"),
                            Description = "Sebész specialista.",
                            Name = "Dr. Szabó Éva",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"),
                            Description = "Egzotikus állatok szakértője.",
                            Name = "Dr. Kiss Tamás",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("12676ff6-f4ba-4b2e-b7c6-531f6b49840a"),
                            Description = "A klinika segédje, minden munkában ott van.",
                            Name = "Hajdu Eszter",
                            Type = 2
                        });
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HistoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Medicine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TreatmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("81e7aca6-9217-4d4c-9ee5-07182b2a634c"),
                            Description = "Alapvizsgálat",
                            Length = 30,
                            Medicine = "Védőoltás",
                            TreatmentId = new Guid("74efd758-26f6-4280-9ea8-a4c043dda630"),
                            Type = 1
                        });
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d966f69-72b7-4817-aaec-7580ed2c15f3"),
                            BirthDate = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A falu híres állatorvosa.",
                            Name = "Kovács János",
                            Residence = "Budapest"
                        },
                        new
                        {
                            Id = new Guid("a0767c2c-2803-4d60-92fe-74741026ad8e"),
                            BirthDate = new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kutyakozmetikus, minden kutyát széppé varázsol.",
                            Name = "Szabó Katalin",
                            Residence = "Debrecen"
                        });
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Treatment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18)
                        .HasColumnType("decimal(18,0)");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PersonId");

                    b.ToTable("Treatments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74efd758-26f6-4280-9ea8-a4c043dda630"),
                            Amount = 15000m,
                            AnimalId = new Guid("0d4ad174-8291-4747-a198-b8a9b774b2d5"),
                            Date = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rutin vizsgálat",
                            DoctorId = new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"),
                            PersonId = new Guid("6d966f69-72b7-4817-aaec-7580ed2c15f3")
                        });
                });

            modelBuilder.Entity("AnimalPerson", b =>
                {
                    b.HasOne("DrPetClinic.Data.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrPetClinic.Data.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.ConsultationTime", b =>
                {
                    b.HasOne("DrPetClinic.Data.Entities.Employee", "Employee")
                        .WithMany("ConsultationTimes")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Entry", b =>
                {
                    b.HasOne("DrPetClinic.Data.Entities.Entry", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DrPetClinic.Data.Entities.Treatment", "Treatment")
                        .WithMany("Entries")
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("History");

                    b.Navigation("Treatment");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Treatment", b =>
                {
                    b.HasOne("DrPetClinic.Data.Entities.Animal", "Animal")
                        .WithMany("Treatments")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPetClinic.Data.Entities.Employee", "Doctor")
                        .WithMany("Treatments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPetClinic.Data.Entities.Person", "Person")
                        .WithMany("Treatments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Doctor");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Animal", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Employee", b =>
                {
                    b.Navigation("ConsultationTimes");

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Person", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPetClinic.Data.Entities.Treatment", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
