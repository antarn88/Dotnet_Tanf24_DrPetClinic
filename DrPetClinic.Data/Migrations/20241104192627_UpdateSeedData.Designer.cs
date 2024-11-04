﻿// <auto-generated />
using System;
using DrPetClinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DrPetClinic.Data.Migrations
{
    [DbContext(typeof(DrPetClinicDBContext))]
    [Migration("20241104192627_UpdateSeedData")]
    partial class UpdateSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("e1a58661-2023-4132-98fd-ff4663f18ab6"),
                            BirthDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ő a falu legszorgalmasabb terelője.",
                            Name = "Bodri",
                            Species = "Kutya",
                            Status = "Jó egészségnek örvend",
                            Type = "Puli"
                        },
                        new
                        {
                            Id = new Guid("67df453c-c08d-492c-93cf-53cda281e7d0"),
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
                            Id = new Guid("2904afbd-e2d0-4e95-9f19-e78d92089802"),
                            DayOfWeek = 1,
                            Description = "Általános rendelési idő hétfőn.",
                            EmployeeId = new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"),
                            EndTime = new TimeSpan(0, 17, 0, 0, 0),
                            IsAvailable = true,
                            Month = (byte)10,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            Week = (byte)1,
                            Year = (short)2023
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
                            Id = new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"),
                            Description = "Szakértő állatorvos.",
                            Name = "Dr. Vakarcs Pál",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("c5b01d5e-68e5-40d0-930e-47dbb1ad1af5"),
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
                            Id = new Guid("a5768f27-78b5-41b0-9583-3ab37a7c6a51"),
                            Description = "Alapvizsgálat",
                            Length = 30,
                            Medicine = "Védőoltás",
                            TreatmentId = new Guid("82f241ba-e5ef-47d6-a494-452630e2c953"),
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
                            Id = new Guid("31dc8872-2813-4c3b-976b-54422d122611"),
                            BirthDate = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A falu híres állatorvosa.",
                            Name = "Kovács János",
                            Residence = "Budapest"
                        },
                        new
                        {
                            Id = new Guid("49b5714e-c1b2-4a45-af0b-14de38f751db"),
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
                            Id = new Guid("82f241ba-e5ef-47d6-a494-452630e2c953"),
                            Amount = 15000m,
                            AnimalId = new Guid("e1a58661-2023-4132-98fd-ff4663f18ab6"),
                            Date = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rutin vizsgálat",
                            DoctorId = new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"),
                            PersonId = new Guid("31dc8872-2813-4c3b-976b-54422d122611")
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
