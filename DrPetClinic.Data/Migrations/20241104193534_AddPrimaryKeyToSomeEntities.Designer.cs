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
    [Migration("20241104193534_AddPrimaryKeyToSomeEntities")]
    partial class AddPrimaryKeyToSomeEntities
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
                            Id = new Guid("d73e2118-4f6d-4719-a265-b90c50369ead"),
                            BirthDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ő a falu legszorgalmasabb terelője.",
                            Name = "Bodri",
                            Species = "Kutya",
                            Status = "Jó egészségnek örvend",
                            Type = "Puli"
                        },
                        new
                        {
                            Id = new Guid("e7b89889-83ea-4b00-8e9c-96d2d76de738"),
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
                            Id = new Guid("47caa033-d855-48f7-9cb1-07aeff1db2d5"),
                            DayOfWeek = 1,
                            Description = "Általános rendelési idő hétfőn.",
                            EmployeeId = new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"),
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
                            Id = new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"),
                            Description = "Szakértő állatorvos.",
                            Name = "Dr. Vakarcs Pál",
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("584a47e1-1a49-4ce7-a786-9137ddba4490"),
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
                            Id = new Guid("d4c14f6e-4168-4074-918a-4fea84f94254"),
                            Description = "Alapvizsgálat",
                            Length = 30,
                            Medicine = "Védőoltás",
                            TreatmentId = new Guid("df99b360-33c8-4f35-816f-5561fb83ba67"),
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
                            Id = new Guid("f5bf810c-a032-4a08-8a42-aa2de50d17ec"),
                            BirthDate = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A falu híres állatorvosa.",
                            Name = "Kovács János",
                            Residence = "Budapest"
                        },
                        new
                        {
                            Id = new Guid("4595696c-1036-409e-b8ca-7be653bee204"),
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
                            Id = new Guid("df99b360-33c8-4f35-816f-5561fb83ba67"),
                            Amount = 15000m,
                            AnimalId = new Guid("d73e2118-4f6d-4719-a265-b90c50369ead"),
                            Date = new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rutin vizsgálat",
                            DoctorId = new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"),
                            PersonId = new Guid("f5bf810c-a032-4a08-8a42-aa2de50d17ec")
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
