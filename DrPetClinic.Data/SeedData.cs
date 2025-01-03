﻿using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;

namespace DrPetClinic.Data
{
    public static class SeedData
    {
        private static readonly Guid DrVakarcsId = Guid.NewGuid();
        private static readonly Guid DrSzaboId = Guid.NewGuid();
        private static readonly Guid DrKissId = Guid.NewGuid();
        private static readonly Guid HajduEszterId = Guid.NewGuid();
        public static readonly Guid BodriId = Guid.NewGuid();
        public static readonly Guid CirmiId = Guid.NewGuid();
        public static readonly Guid KovacsJanosId = Guid.NewGuid();
        private static readonly Guid TreatmentId = Guid.NewGuid();

        public static readonly Guid SzaboKatalinId = Guid.NewGuid();

        public static List<Animal> GetAnimals()
        {
            return new List<Animal>
            {
                new Animal
                {
                    Id = BodriId,
                    Species = "Kutya",
                    Type = "Puli",
                    BirthDate = new DateTime(2020, 3, 1),
                    Name = "Bodri",
                    Status = "Jó egészségnek örvend",
                    Description = "Ő a falu legszorgalmasabb terelője.",
                    Owners = new List<Person>(),
                    Treatments = new List<Treatment>()
                },
                new Animal
                {
                    Id = CirmiId,
                    Species = "Macska",
                    Type = "Sziámi",
                    BirthDate = new DateTime(2019, 6, 21),
                    Name = "Cirmi",
                    Status = "Kissé morcos",
                    Description = "A kajáért él-hal, de csak akkor enged közel, ha akar.",
                    Owners = new List<Person>(),
                    Treatments = new List<Treatment>()
                }
            };
        }

        public static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person
                {
                    Id = KovacsJanosId,
                    Name = "Kovács János",
                    BirthDate = new DateTime(1985, 5, 15),
                    Residence = "Budapest",
                    Description = "A falu híres állatorvosa.",
                },
                new Person
                {
                    Id = SzaboKatalinId,
                    Name = "Szabó Katalin",
                    BirthDate = new DateTime(1992, 9, 30),
                    Residence = "Debrecen",
                    Description = "Kutyakozmetikus, minden kutyát széppé varázsol.",
                }
            };
        }

        public static List<dynamic> GetAnimalOwners()
        {
            return new List<dynamic>
            {
                new { AnimalsId = BodriId, OwnersId = KovacsJanosId },
                new { AnimalsId = CirmiId, OwnersId = SzaboKatalinId },
            };
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = DrVakarcsId,
                    Name = "Dr. Vakarcs Pál",
                    Type = EmployeeType.Doctor,
                    Description = "Szakértő állatorvos.",
                    ConsultationTimes = new List<ConsultationTime>(),
                    Treatments = new List<Treatment>()
                },
                new Employee
                {
                    Id = DrSzaboId,
                    Name = "Dr. Szabó Éva",
                    Type = EmployeeType.Doctor,
                    Description = "Sebész specialista.",
                    ConsultationTimes = new List<ConsultationTime>(),
                    Treatments = new List<Treatment>()
                },
                new Employee
                {
                    Id = DrKissId,
                    Name = "Dr. Kiss Tamás",
                    Type = EmployeeType.Doctor,
                    Description = "Egzotikus állatok szakértője.",
                    ConsultationTimes = new List<ConsultationTime>(),
                    Treatments = new List<Treatment>()
                },
                new Employee
                {
                    Id = HajduEszterId,
                    Name = "Hajdu Eszter",
                    Type = EmployeeType.Assistant,
                    Description = "A klinika segédje, minden munkában ott van.",
                    ConsultationTimes = new List<ConsultationTime>(),
                    Treatments = new List<Treatment>()
                }
            };
        }

        public static List<ConsultationTime> GetConsultationTimes()
        {
            return new List<ConsultationTime>
            {
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 46,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő hétfőn.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 46,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő kedden.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Csütörtöki rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 49,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(15, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 50,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0),
                    IsAvailable = true,
                    Description = "Pénteki rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 51,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(11, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Hétfői rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő hétfőn.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő kedden.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 48,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő hétfőn.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 48,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő kedden.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 48,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Csütörtöki rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 49,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Csütörtöki rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 50,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(15, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 51,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(15, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0),
                    IsAvailable = true,
                    Description = "Pénteki rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 48,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0),
                    IsAvailable = true,
                    Description = "Pénteki rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 52,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0),
                    IsAvailable = true,
                    Description = "Pénteki rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 53,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0),
                    IsAvailable = true,
                    Description = "Pénteki rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 52,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Csütörtöki rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 12,
                    Week = 53,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Csütörtöki rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 46,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 46,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(8, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrSzaboId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rendelés.",
                    EmployeeId = DrKissId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 46,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rövid rendelés.",
                    EmployeeId = DrVakarcsId
                },
                new ConsultationTime
                {
                    Id = Guid.NewGuid(),
                    Year = 2024,
                    Month = 11,
                    Week = 47,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    IsAvailable = true,
                    Description = "Szerdai rövid rendelés.",
                    EmployeeId = DrVakarcsId
                }
            };
        }

        public static List<Treatment> GetTreatments()
        {
            return new List<Treatment>
            {
                new Treatment
                {
                    Id = TreatmentId,
                    Description = "Rutin vizsgálat",
                    Amount = 15000,
                    Date = new DateTime(2023, 10, 3),
                    DoctorId = DrVakarcsId,
                    AnimalId = BodriId,
                    PersonId = KovacsJanosId,
                    Entries = new List<Entry>()
                },
                new Treatment
                {
                    Id = Guid.NewGuid(),
                    Description = "Bolhaírtás",
                    Amount = 30000,
                    Date = new DateTime(2024, 12, 4),
                    DoctorId = DrKissId,
                    AnimalId = CirmiId,
                    PersonId = SzaboKatalinId,
                    Entries = new List<Entry>()
                }
            };
        }

        public static List<Entry> GetEntries()
        {
            return new List<Entry>
            {
                new Entry
                {
                    Id = Guid.NewGuid(),
                    Description = "Alapvizsgálat",
                    Type = EntryType.Examination,
                    Medicine = "Védőoltás",
                    Length = 30,
                    TreatmentId = TreatmentId
                }
            };
        }
    }
}
