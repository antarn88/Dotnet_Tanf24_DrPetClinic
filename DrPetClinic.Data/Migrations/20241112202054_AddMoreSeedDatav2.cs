using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedDatav2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("97ac43eb-5260-4929-b159-4734c3f4c522"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("e3c7c860-8f1e-4fd4-9e2e-7d705971c84e"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 },
                    { new Guid("70262b71-869c-4442-a88d-6cb39720e908"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("ff6465cf-dd39-47d4-8e83-632193537f6d"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("591045af-04fe-410b-a5d3-fd80aa9df589"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("ba5b38e7-29c2-4a0a-bcd5-2777ed829eb0"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("08561a0a-84f2-44f6-9d55-2baf42719021"), 5, "Pénteki rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("1cd3d997-1082-489e-84ab-9fc65b7d554d"), 4, "Csütörtöki rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("1d8bce90-46ff-4929-99ee-d974a6ac31f3"), 4, "Csütörtöki rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("2d542049-1499-492c-ad5b-cff28434bf60"), 3, "Szerdai rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("32d7e42b-d5a4-4a28-84f5-49589bd04023"), 1, "Általános rendelési idő hétfőn.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("3b62ba2a-85e3-4abe-ad55-8652e1be475b"), 2, "Általános rendelési idő kedden.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("3d3f26bf-3a91-4729-a8f4-5c0dbdee805d"), 2, "Általános rendelési idő kedden.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("4a9f6959-6b37-4a10-8189-ed093c432831"), 1, "Általános rendelési idő hétfőn.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("51aa826b-b13e-44ac-978e-de29c38d8d07"), 4, "Csütörtöki rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("5d89b2f3-0fa0-4345-ac11-727df01479df"), 3, "Szerdai rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("62cbd30e-423a-488a-bee5-f746fe1d0ddd"), 1, "Hétfői rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("6342e9da-4798-45de-a6be-2a5a865356fd"), 4, "Csütörtöki rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("80da5554-59db-4e2b-880d-3a94af23e5e2"), 4, "Csütörtöki rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("88a795f0-3e23-44cb-9123-e2c7831f4436"), 5, "Pénteki rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("8d183a11-905e-4ee7-ba60-1fef01da3a2a"), 3, "Szerdai rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("9f18870e-3438-41e0-b0b9-efb2ef832fb5"), 5, "Pénteki rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("a1db92c6-4e47-42fe-957a-ef47599d197a"), 5, "Pénteki rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("ab3f292b-0f91-4535-bbd2-7b12add20a9c"), 3, "Szerdai rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("ac112a53-5446-4d8e-a7a5-9f42bd4c9e8b"), 5, "Pénteki rendelés.", new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("b7b9be7e-afc6-4b6e-abd6-1e51aa15d3ac"), 3, "Szerdai rövid rendelés.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("d40b3dee-060e-477e-98a6-951178f1fb7f"), 3, "Szerdai rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("de054a50-d3cf-454e-9207-ebfdc025b24d"), 2, "Általános rendelési idő kedden.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("e878d18e-aad3-4a5b-b404-383146ac2451"), 3, "Szerdai rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("e8f557f4-1502-438b-8d30-ee3ab269f545"), 1, "Általános rendelési idő hétfőn.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("f1321eeb-913b-40df-b1c3-9a7b934a44d6"), 3, "Szerdai rövid rendelés.", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("f4c23f58-9cd8-4934-b14e-4e0b6e4786af"), 3, "Szerdai rendelés.", new Guid("70262b71-869c-4442-a88d-6cb39720e908"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("307aec14-edb4-418a-9b0f-b19092a54113"), 15000m, new Guid("e3c7c860-8f1e-4fd4-9e2e-7d705971c84e"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"), new Guid("ba5b38e7-29c2-4a0a-bcd5-2777ed829eb0") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("8ceacae8-6c3a-4c31-a936-f4582da9156d"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("307aec14-edb4-418a-9b0f-b19092a54113"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("97ac43eb-5260-4929-b159-4734c3f4c522"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("08561a0a-84f2-44f6-9d55-2baf42719021"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1cd3d997-1082-489e-84ab-9fc65b7d554d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1d8bce90-46ff-4929-99ee-d974a6ac31f3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2d542049-1499-492c-ad5b-cff28434bf60"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("32d7e42b-d5a4-4a28-84f5-49589bd04023"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3b62ba2a-85e3-4abe-ad55-8652e1be475b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3d3f26bf-3a91-4729-a8f4-5c0dbdee805d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4a9f6959-6b37-4a10-8189-ed093c432831"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("51aa826b-b13e-44ac-978e-de29c38d8d07"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5d89b2f3-0fa0-4345-ac11-727df01479df"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("62cbd30e-423a-488a-bee5-f746fe1d0ddd"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6342e9da-4798-45de-a6be-2a5a865356fd"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("80da5554-59db-4e2b-880d-3a94af23e5e2"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("88a795f0-3e23-44cb-9123-e2c7831f4436"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8d183a11-905e-4ee7-ba60-1fef01da3a2a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9f18870e-3438-41e0-b0b9-efb2ef832fb5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a1db92c6-4e47-42fe-957a-ef47599d197a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ab3f292b-0f91-4535-bbd2-7b12add20a9c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ac112a53-5446-4d8e-a7a5-9f42bd4c9e8b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b7b9be7e-afc6-4b6e-abd6-1e51aa15d3ac"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d40b3dee-060e-477e-98a6-951178f1fb7f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("de054a50-d3cf-454e-9207-ebfdc025b24d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e878d18e-aad3-4a5b-b404-383146ac2451"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e8f557f4-1502-438b-8d30-ee3ab269f545"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f1321eeb-913b-40df-b1c3-9a7b934a44d6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f4c23f58-9cd8-4934-b14e-4e0b6e4786af"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ff6465cf-dd39-47d4-8e83-632193537f6d"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("8ceacae8-6c3a-4c31-a936-f4582da9156d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("591045af-04fe-410b-a5d3-fd80aa9df589"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3b7a98e4-030c-420f-bc5e-5587f01838c5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("70262b71-869c-4442-a88d-6cb39720e908"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("307aec14-edb4-418a-9b0f-b19092a54113"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e3c7c860-8f1e-4fd4-9e2e-7d705971c84e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d88a82ad-be57-40e1-84d3-59ee3768fd49"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("ba5b38e7-29c2-4a0a-bcd5-2777ed829eb0"));

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
    }
}
