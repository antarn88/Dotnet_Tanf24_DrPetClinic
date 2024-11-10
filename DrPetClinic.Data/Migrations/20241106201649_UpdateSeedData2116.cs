using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData2116 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("98550b7c-6dc0-47c2-a83d-4e2e7be1136e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8f3c6266-d1c2-4acf-af73-933acd25328c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c2b3aebc-f593-4f65-8bc4-41c0b2a5f0dc"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d9982b4f-9095-458e-a084-8c9610aeaef4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c9bd6299-1a18-4707-898e-90ea60f384f7"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("43529031-dd2a-4e45-8712-2f837c1cca70"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("350fd659-96f7-40f6-9f5e-252ed1106ac7"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b25478f3-e538-4fa3-9c15-a1eb168dc60c"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("6b7549ea-2db4-46bf-b587-56e74f79b4cf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("7f885d88-6e44-4ec9-9d06-e89ea5b8ac8b"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("085e3d10-4f4f-4df6-863f-3277a5966a50"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("0d4ad174-8291-4747-a198-b8a9b774b2d5"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("12676ff6-f4ba-4b2e-b7c6-531f6b49840a"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("6d966f69-72b7-4817-aaec-7580ed2c15f3"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("a0767c2c-2803-4d60-92fe-74741026ad8e"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("3b6b0e08-a8b0-446a-ace1-67d892eb9e2a"), 5, "Pénteki rendelés.", new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)2, (short)2024 },
                    { new Guid("8245fd30-426b-479e-ba1b-75708102adfe"), 4, "Csütörtöki rendelés.", new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)3, (short)2024 },
                    { new Guid("b382828d-c2c9-4cab-a8e8-741b90af273c"), 3, "Szerdai rendelés.", new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)1, (short)2024 },
                    { new Guid("bf47ede7-3754-4f79-982c-58d71f84c52b"), 1, "Hétfői rendelés.", new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)3, (short)2024 },
                    { new Guid("ece94967-6c2d-4eab-8a3d-046a52bebe45"), 2, "Általános rendelési idő kedden.", new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)2, (short)2024 },
                    { new Guid("eeff6bd6-ace8-4b53-9883-68d5cebb73f8"), 1, "Általános rendelési idő hétfőn.", new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)1, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("74efd758-26f6-4280-9ea8-a4c043dda630"), 15000m, new Guid("0d4ad174-8291-4747-a198-b8a9b774b2d5"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"), new Guid("6d966f69-72b7-4817-aaec-7580ed2c15f3") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("81e7aca6-9217-4d4c-9ee5-07182b2a634c"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("74efd758-26f6-4280-9ea8-a4c043dda630"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("085e3d10-4f4f-4df6-863f-3277a5966a50"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3b6b0e08-a8b0-446a-ace1-67d892eb9e2a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8245fd30-426b-479e-ba1b-75708102adfe"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b382828d-c2c9-4cab-a8e8-741b90af273c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bf47ede7-3754-4f79-982c-58d71f84c52b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ece94967-6c2d-4eab-8a3d-046a52bebe45"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("eeff6bd6-ace8-4b53-9883-68d5cebb73f8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("12676ff6-f4ba-4b2e-b7c6-531f6b49840a"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("81e7aca6-9217-4d4c-9ee5-07182b2a634c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a0767c2c-2803-4d60-92fe-74741026ad8e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d9c9b306-82c6-4060-95c4-bae423e2bcd9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e515d132-3c4b-4afc-be5a-d446847f4eb2"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("74efd758-26f6-4280-9ea8-a4c043dda630"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("0d4ad174-8291-4747-a198-b8a9b774b2d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("410159e8-4ecb-486d-b757-778ab15ddb3d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("6d966f69-72b7-4817-aaec-7580ed2c15f3"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("6b7549ea-2db4-46bf-b587-56e74f79b4cf"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("98550b7c-6dc0-47c2-a83d-4e2e7be1136e"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("c9bd6299-1a18-4707-898e-90ea60f384f7"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("350fd659-96f7-40f6-9f5e-252ed1106ac7"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("7f885d88-6e44-4ec9-9d06-e89ea5b8ac8b"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("8f3c6266-d1c2-4acf-af73-933acd25328c"), 2, "Általános rendelési idő kedden.", new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)1, (short)2024 },
                    { new Guid("c2b3aebc-f593-4f65-8bc4-41c0b2a5f0dc"), 3, "Általános rendelési idő szerdán.", new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)1, (short)2024 },
                    { new Guid("d9982b4f-9095-458e-a084-8c9610aeaef4"), 1, "Általános rendelési idő hétfőn.", new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)1, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("b25478f3-e538-4fa3-9c15-a1eb168dc60c"), 15000m, new Guid("6b7549ea-2db4-46bf-b587-56e74f79b4cf"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("b255276a-a4b7-436d-87f2-47abb5a53cd4"), new Guid("7f885d88-6e44-4ec9-9d06-e89ea5b8ac8b") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("43529031-dd2a-4e45-8712-2f837c1cca70"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("b25478f3-e538-4fa3-9c15-a1eb168dc60c"), 1 });
        }
    }
}
