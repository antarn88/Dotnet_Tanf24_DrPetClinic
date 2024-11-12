using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("487bfce6-86ba-4819-816a-a088dc4257c9"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("e9346cfe-fbbc-4807-bf6a-5974f0e6ee7e"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("6c428cfd-ec5e-4bc3-9d99-6ccc9d1f16c7"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("36b6d1e6-a49a-4e9d-8cf2-8dc72d70bab8"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("b17aeb04-2dfb-4993-99d3-ed2993869fd6"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("1a118924-1fa8-4b6a-9a4e-c3e8cc5638b6"), 4, "Csütörtöki rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("358ddba0-bf31-4eff-8f92-a0afccbf8394"), 5, "Pénteki rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("3aa47318-a237-4ac4-af6b-6751ddd9a591"), 2, "Általános rendelési idő kedden.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("455fc92b-6817-4740-a8df-7dce13d0622a"), 5, "Pénteki rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("5f3754ba-3621-42ac-9bb9-9adf777f2501"), 1, "Általános rendelési idő hétfőn.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("66ea1cdd-2697-4a5a-a785-007c7654971a"), 4, "Csütörtöki rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("6bb00bd1-3d19-4412-ae4d-c8e882b00852"), 2, "Általános rendelési idő kedden.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("74e5ea5c-ea80-4eb8-ad1c-3ca1768eff91"), 4, "Csütörtöki rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("84b6008a-5e9b-4775-bcbf-4ae44013ee7f"), 2, "Általános rendelési idő kedden.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("8f469f59-4f05-4dc0-84b7-a722d1836c06"), 1, "Hétfői rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("a3e9af46-94b5-42dd-9a1f-ef24834780a4"), 4, "Csütörtöki rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("a5dfde18-43bf-4e59-852d-85b21486c6e3"), 5, "Pénteki rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("aacca0f1-b0c3-4194-a301-3c9b2c231cd3"), 5, "Pénteki rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("b9b6115e-25e7-4638-b8cf-6e8d50cfcaaa"), 1, "Általános rendelési idő hétfőn.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("ba46f3af-16bd-4f9a-aac3-1d9e73e14035"), 1, "Általános rendelési idő hétfőn.", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("c8aa0dd3-910e-40ab-998c-a2387a1af5f6"), 3, "Szerdai rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("e4b9fc1b-d4b6-4381-bc43-438f0318a210"), 4, "Csütörtöki rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("f5857978-71bc-4484-85ba-7eb1df914916"), 3, "Szerdai rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("fde43c6c-57b3-4ded-85c2-0208f1c3c547"), 5, "Pénteki rendelés.", new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("fe65b404-8d24-4eeb-b77d-18a8a27e49e4"), 3, "Szerdai rendelés.", new Guid("3174168b-330b-4157-8891-a62198bc8fd8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("47474773-d014-44ca-856b-8499c9ddcde2"), 15000m, new Guid("487bfce6-86ba-4819-816a-a088dc4257c9"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"), new Guid("b17aeb04-2dfb-4993-99d3-ed2993869fd6") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("76f25691-3d4f-4676-a460-fc6f626a73c6"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("47474773-d014-44ca-856b-8499c9ddcde2"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e9346cfe-fbbc-4807-bf6a-5974f0e6ee7e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1a118924-1fa8-4b6a-9a4e-c3e8cc5638b6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("358ddba0-bf31-4eff-8f92-a0afccbf8394"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3aa47318-a237-4ac4-af6b-6751ddd9a591"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("455fc92b-6817-4740-a8df-7dce13d0622a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5f3754ba-3621-42ac-9bb9-9adf777f2501"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("66ea1cdd-2697-4a5a-a785-007c7654971a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6bb00bd1-3d19-4412-ae4d-c8e882b00852"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("74e5ea5c-ea80-4eb8-ad1c-3ca1768eff91"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("84b6008a-5e9b-4775-bcbf-4ae44013ee7f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8f469f59-4f05-4dc0-84b7-a722d1836c06"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a3e9af46-94b5-42dd-9a1f-ef24834780a4"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a5dfde18-43bf-4e59-852d-85b21486c6e3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("aacca0f1-b0c3-4194-a301-3c9b2c231cd3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b9b6115e-25e7-4638-b8cf-6e8d50cfcaaa"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ba46f3af-16bd-4f9a-aac3-1d9e73e14035"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c8aa0dd3-910e-40ab-998c-a2387a1af5f6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e4b9fc1b-d4b6-4381-bc43-438f0318a210"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f5857978-71bc-4484-85ba-7eb1df914916"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fde43c6c-57b3-4ded-85c2-0208f1c3c547"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fe65b404-8d24-4eeb-b77d-18a8a27e49e4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6c428cfd-ec5e-4bc3-9d99-6ccc9d1f16c7"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("76f25691-3d4f-4676-a460-fc6f626a73c6"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("36b6d1e6-a49a-4e9d-8cf2-8dc72d70bab8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3174168b-330b-4157-8891-a62198bc8fd8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9caab3d8-3157-4db5-8925-62e8277ed5b5"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("47474773-d014-44ca-856b-8499c9ddcde2"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("487bfce6-86ba-4819-816a-a088dc4257c9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2a2393a8-180c-4bab-82cc-9dbfed5f1cff"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b17aeb04-2dfb-4993-99d3-ed2993869fd6"));

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
    }
}
