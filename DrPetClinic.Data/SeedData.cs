using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;

namespace DrPetClinic.Data
{
    public static class SeedData
    {
        private static readonly Guid DrVakarcsId = Guid.NewGuid();
        private static readonly Guid HajduEszterId = Guid.NewGuid();
        private static readonly Guid BodriId = Guid.NewGuid();
        private static readonly Guid KovacsJanosId = Guid.NewGuid();
        private static readonly Guid TreatmentId = Guid.NewGuid();

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
                    Id = Guid.NewGuid(),
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
                    Animals = new List<Animal>(),
                    Treatments = new List<Treatment>()
                },
                new Person
                {
                    Id = Guid.NewGuid(),
                    Name = "Szabó Katalin",
                    BirthDate = new DateTime(1992, 9, 30),
                    Residence = "Debrecen",
                    Description = "Kutyakozmetikus, minden kutyát széppé varázsol.",
                    Animals = new List<Animal>(),
                    Treatments = new List<Treatment>()
                }
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
                    Year = 2023,
                    Month = 10,
                    Week = 1,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0),
                    IsAvailable = true,
                    Description = "Általános rendelési idő hétfőn.",
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

