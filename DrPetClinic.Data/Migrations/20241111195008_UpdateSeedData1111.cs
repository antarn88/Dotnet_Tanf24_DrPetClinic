using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("ba502a92-c371-4389-a632-8e497b628a33"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("f746bae5-ddb4-45ed-a8c0-8c787f076ba3"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("2fdb6e36-ef2d-4378-8565-5113f13ce6a8"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("3f7a703a-43df-4198-8bd8-92ef957a311d"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 },
                    { new Guid("9f03b2af-b3cd-425d-9f99-c4fde642f550"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("a3225b50-055b-4581-b31b-4455403266ea"), "Sebész specialista.", "Dr. Szabó Éva", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("06ccf02f-c16d-4f86-bd81-2ea793e9efe4"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("d8f8bd4d-4bd3-4a3a-849a-13e8dead6a5a"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("16baa96b-cc8f-4840-a1af-12b5b68a1c26"), 2, "Általános rendelési idő kedden.", new Guid("9f03b2af-b3cd-425d-9f99-c4fde642f550"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("81574180-d0b2-4792-8f6a-0bddc59ba09a"), 3, "Szerdai rendelés.", new Guid("a3225b50-055b-4581-b31b-4455403266ea"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("a98c0f4d-b6d9-4e95-b5d8-3ad2d414135c"), 1, "Általános rendelési idő hétfőn.", new Guid("9f03b2af-b3cd-425d-9f99-c4fde642f550"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("c817c60a-b6e9-4d56-978c-f8022f27d0d0"), 5, "Pénteki rendelés.", new Guid("3f7a703a-43df-4198-8bd8-92ef957a311d"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("dcb6fbf7-727f-4e92-a5a7-7ce68b83e133"), 1, "Hétfői rendelés.", new Guid("3f7a703a-43df-4198-8bd8-92ef957a311d"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("ff3449dd-b266-4355-9ff9-ebb094725731"), 4, "Csütörtöki rendelés.", new Guid("a3225b50-055b-4581-b31b-4455403266ea"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("61f431d5-6e69-42aa-a9be-fffc29d3d0bf"), 15000m, new Guid("f746bae5-ddb4-45ed-a8c0-8c787f076ba3"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("9f03b2af-b3cd-425d-9f99-c4fde642f550"), new Guid("d8f8bd4d-4bd3-4a3a-849a-13e8dead6a5a") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("0602dad3-ac5b-45f5-be43-cbd28e6a95ce"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("61f431d5-6e69-42aa-a9be-fffc29d3d0bf"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("ba502a92-c371-4389-a632-8e497b628a33"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("16baa96b-cc8f-4840-a1af-12b5b68a1c26"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("81574180-d0b2-4792-8f6a-0bddc59ba09a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a98c0f4d-b6d9-4e95-b5d8-3ad2d414135c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c817c60a-b6e9-4d56-978c-f8022f27d0d0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("dcb6fbf7-727f-4e92-a5a7-7ce68b83e133"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ff3449dd-b266-4355-9ff9-ebb094725731"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2fdb6e36-ef2d-4378-8565-5113f13ce6a8"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("0602dad3-ac5b-45f5-be43-cbd28e6a95ce"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("06ccf02f-c16d-4f86-bd81-2ea793e9efe4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3f7a703a-43df-4198-8bd8-92ef957a311d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a3225b50-055b-4581-b31b-4455403266ea"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("61f431d5-6e69-42aa-a9be-fffc29d3d0bf"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("f746bae5-ddb4-45ed-a8c0-8c787f076ba3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9f03b2af-b3cd-425d-9f99-c4fde642f550"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("d8f8bd4d-4bd3-4a3a-849a-13e8dead6a5a"));

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
    }
}
