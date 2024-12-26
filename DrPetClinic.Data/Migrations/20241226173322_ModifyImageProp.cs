using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyImageProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("fdfab8ba-e126-415f-bbed-f9f0276fab95"), new Guid("2e008dc3-6dc8-4632-93ef-4a77dc48dadc") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("ff6c74a4-efdb-4ed4-89a6-6a62b6fdd54f"), new Guid("1a21d10b-3b18-4165-ba72-c2bd3fc39b20") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("00109ad6-452f-4848-83ec-15ed7072629b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1e7c4685-a348-4f83-8dce-fb2b425e7996"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("223eb87b-0878-40e1-8468-2e77c151ab8d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2a037cfb-c931-4046-9155-93f777a97049"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4185da50-f91e-486e-acd1-055b7a010c9b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("460234b2-c683-4ccb-aa87-d99b3ae03e65"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4b77460e-a04a-4108-9efa-27511bd6fb27"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("550f88f3-c2ad-4549-b340-6849e236d857"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5ed7f0a2-9ccf-4432-9a57-bfd262c26e9c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5f618221-34da-4abf-afd9-922837ff757c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("67095a0a-b9c1-4a77-8cd1-2312e92b7b31"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6ee3e4ee-0af8-43d2-9a96-31b749a7ed38"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("707c18a9-3a8c-4d16-b071-0bd4acc8054f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("77c4d25a-4451-48ea-9e92-281606a21f69"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("7e7d98f9-8700-4630-913d-f275b4538d3d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("7fe1aa78-cf54-4a8c-ad1a-8e95cea0ae70"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("84cde399-ed4c-433f-ba24-181be8074109"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8da869b5-f654-42f3-968b-4ddedebdf337"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9b5b81f4-7a2b-485e-82a5-1967340aaec8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a11773ba-f325-4e4a-8868-7f6648a970bc"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a88f4a14-82e7-437f-9af3-a6b6d3189888"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("aeff1ab7-f633-4e7a-be25-e03255a7322a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d0350634-15d9-4229-8e23-9493e3cdedae"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e0002892-001c-4b17-8395-a05c35fb40f6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e6924845-940d-48b3-847c-7f95ed4567de"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e999a369-dbba-4fa2-a689-afb839b47347"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2cb98491-25f9-4506-a95d-b5e1f982eee1"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("bbe88c8d-0f0d-479d-a388-18f6a4027b67"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d1a02358-3b79-4dd2-a828-b9d58a888c91"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("fdfab8ba-e126-415f-bbed-f9f0276fab95"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("2e008dc3-6dc8-4632-93ef-4a77dc48dadc"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("4a6d5778-1c8c-414d-9fd5-ad16159833b3"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("ff6c74a4-efdb-4ed4-89a6-6a62b6fdd54f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("1a21d10b-3b18-4165-ba72-c2bd3fc39b20"));

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Employees",
                newName: "ImageFileName");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("00f62fb3-abf9-4d78-a343-b68e6b72c34b"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("83c2bd58-1153-4813-85b9-a1089c38c49d"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "ImageFileName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), 0, "53641a0d-bb99-4d32-832b-c10772336f5e", "Sebész specialista.", null, false, null, false, null, "Dr. Szabó Éva", null, null, null, null, false, null, false, 1, null },
                    { new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), 0, "0b1f8dbb-7b5c-4e7e-8bf5-822d52fd7215", "Egzotikus állatok szakértője.", null, false, null, false, null, "Dr. Kiss Tamás", null, null, null, null, false, null, false, 1, null },
                    { new Guid("7ff96fd0-a31a-41d6-bf22-a7f540aea5cc"), 0, "b8d50290-a316-4932-8c56-6e9ab4e8e71a", "A klinika segédje, minden munkában ott van.", null, false, null, false, null, "Hajdu Eszter", null, null, null, null, false, null, false, 2, null },
                    { new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), 0, "14193bd5-e615-43f0-9a58-0153fa5aad08", "Szakértő állatorvos.", null, false, null, false, null, "Dr. Vakarcs Pál", null, null, null, null, false, null, false, 1, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("383481bc-2f40-403c-97e2-0c7cb6680907"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("bebd92bb-f0f6-42a4-bbd8-83103fec09bc"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("00f62fb3-abf9-4d78-a343-b68e6b72c34b"), new Guid("bebd92bb-f0f6-42a4-bbd8-83103fec09bc") },
                    { new Guid("83c2bd58-1153-4813-85b9-a1089c38c49d"), new Guid("383481bc-2f40-403c-97e2-0c7cb6680907") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("049279fa-f960-450f-94fc-fcd1292a3677"), 3, "Szerdai rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("0681c983-407e-4902-a1de-683ec42a4f91"), 1, "Általános rendelési idő hétfőn.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("0749d6c5-e3e4-4b4d-bc16-4fddce086180"), 4, "Csütörtöki rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("0f48fca3-bfee-4a81-a405-f3049c1fa0a4"), 5, "Pénteki rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("10c1dfba-dbb2-477c-b8d1-ad1930c5c1f5"), 4, "Csütörtöki rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("2615118f-32b6-45c3-830d-24457e4d8e92"), 4, "Csütörtöki rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("26df68e5-7dd4-4acb-8b53-7580cdba91ea"), 2, "Általános rendelési idő kedden.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("28b920ae-ddfc-4230-a851-397dd7be6190"), 4, "Csütörtöki rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("2a1c0034-7e75-4a00-8ab2-9724e3dc2034"), 3, "Szerdai rövid rendelés.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("34aa68ea-fe33-4135-82d0-a3fac168e0c5"), 2, "Általános rendelési idő kedden.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("38bf38fd-8005-4fa5-9d8f-a213b92b1e39"), 4, "Csütörtöki rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("47db5003-5850-4e28-8aa8-0686891906fa"), 1, "Hétfői rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("53890094-d9e5-4d6a-b709-5573cc36ead0"), 1, "Általános rendelési idő hétfőn.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("5835175f-40e6-4227-a55d-002e4a2c21b0"), 5, "Pénteki rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("60fe77b7-44fe-44f9-a81b-bf3fa4b6eab0"), 3, "Szerdai rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("6db66dfe-9d24-49ab-8011-75213b630be5"), 3, "Szerdai rövid rendelés.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("6f229aae-3694-41ce-b60e-ac2d027dd57e"), 5, "Pénteki rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("7930e680-4f00-4296-8f4b-aa23276e42b9"), 5, "Pénteki rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("7b37c317-da66-4627-8c50-57c828394c66"), 3, "Szerdai rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("8ed660aa-7481-4f98-b942-5136bf0c2604"), 3, "Szerdai rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("99e1e260-ecfa-4d9b-8f5f-d335608a01d5"), 5, "Pénteki rendelés.", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("9d933e87-9bc0-4d71-a37a-9d3ddbf1eab8"), 3, "Szerdai rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("d423b3a7-6427-4b77-a0bf-a1339f71be1d"), 1, "Általános rendelési idő hétfőn.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("d9cca61f-d686-4253-b994-57bc58715d97"), 3, "Szerdai rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("dce55b49-5ca6-4ebc-be5e-8fdc6ae4a322"), 2, "Általános rendelési idő kedden.", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("e330a6aa-43e0-41a8-ae6b-7e39599ce3de"), 3, "Szerdai rendelés.", new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[,]
                {
                    { new Guid("c6c1bbb7-6bda-4811-a9a5-352da69f6d58"), 30000m, new Guid("00f62fb3-abf9-4d78-a343-b68e6b72c34b"), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolhaírtás", new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"), new Guid("bebd92bb-f0f6-42a4-bbd8-83103fec09bc") },
                    { new Guid("e373ce65-cecc-4402-b484-38a7a1882196"), 15000m, new Guid("83c2bd58-1153-4813-85b9-a1089c38c49d"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"), new Guid("383481bc-2f40-403c-97e2-0c7cb6680907") }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("fd1f8f81-e0a3-42e5-9c6c-f18f5a055edf"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("e373ce65-cecc-4402-b484-38a7a1882196"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("00f62fb3-abf9-4d78-a343-b68e6b72c34b"), new Guid("bebd92bb-f0f6-42a4-bbd8-83103fec09bc") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("83c2bd58-1153-4813-85b9-a1089c38c49d"), new Guid("383481bc-2f40-403c-97e2-0c7cb6680907") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("049279fa-f960-450f-94fc-fcd1292a3677"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0681c983-407e-4902-a1de-683ec42a4f91"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0749d6c5-e3e4-4b4d-bc16-4fddce086180"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0f48fca3-bfee-4a81-a405-f3049c1fa0a4"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("10c1dfba-dbb2-477c-b8d1-ad1930c5c1f5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2615118f-32b6-45c3-830d-24457e4d8e92"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("26df68e5-7dd4-4acb-8b53-7580cdba91ea"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("28b920ae-ddfc-4230-a851-397dd7be6190"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2a1c0034-7e75-4a00-8ab2-9724e3dc2034"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("34aa68ea-fe33-4135-82d0-a3fac168e0c5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("38bf38fd-8005-4fa5-9d8f-a213b92b1e39"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("47db5003-5850-4e28-8aa8-0686891906fa"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("53890094-d9e5-4d6a-b709-5573cc36ead0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5835175f-40e6-4227-a55d-002e4a2c21b0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("60fe77b7-44fe-44f9-a81b-bf3fa4b6eab0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6db66dfe-9d24-49ab-8011-75213b630be5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6f229aae-3694-41ce-b60e-ac2d027dd57e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("7930e680-4f00-4296-8f4b-aa23276e42b9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("7b37c317-da66-4627-8c50-57c828394c66"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8ed660aa-7481-4f98-b942-5136bf0c2604"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("99e1e260-ecfa-4d9b-8f5f-d335608a01d5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9d933e87-9bc0-4d71-a37a-9d3ddbf1eab8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d423b3a7-6427-4b77-a0bf-a1339f71be1d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d9cca61f-d686-4253-b994-57bc58715d97"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("dce55b49-5ca6-4ebc-be5e-8fdc6ae4a322"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e330a6aa-43e0-41a8-ae6b-7e39599ce3de"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ff96fd0-a31a-41d6-bf22-a7f540aea5cc"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("fd1f8f81-e0a3-42e5-9c6c-f18f5a055edf"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c6c1bbb7-6bda-4811-a9a5-352da69f6d58"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("00f62fb3-abf9-4d78-a343-b68e6b72c34b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("01e5e3d7-d50a-4571-b1e4-9679700bee1e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("117613a5-2def-4d99-8fcd-42fc3502218b"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("bebd92bb-f0f6-42a4-bbd8-83103fec09bc"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e373ce65-cecc-4402-b484-38a7a1882196"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("83c2bd58-1153-4813-85b9-a1089c38c49d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bb6c4b80-e7df-4b95-a871-83217aa26a82"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("383481bc-2f40-403c-97e2-0c7cb6680907"));

            migrationBuilder.RenameColumn(
                name: "ImageFileName",
                table: "Employees",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("fdfab8ba-e126-415f-bbed-f9f0276fab95"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("ff6c74a4-efdb-4ed4-89a6-6a62b6fdd54f"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), 0, "e6065c27-4ba0-44d8-b9a3-5109346a9efb", "Sebész specialista.", null, false, null, false, null, "Dr. Szabó Éva", null, null, null, null, false, null, false, 1, null },
                    { new Guid("2cb98491-25f9-4506-a95d-b5e1f982eee1"), 0, "a130b2f8-d9e4-4bf9-99a1-c32be336c7ab", "A klinika segédje, minden munkában ott van.", null, false, null, false, null, "Hajdu Eszter", null, null, null, null, false, null, false, 2, null },
                    { new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), 0, "6fa459b6-f2ac-40e3-b80b-3b3f88516a7f", "Egzotikus állatok szakértője.", null, false, null, false, null, "Dr. Kiss Tamás", null, null, null, null, false, null, false, 1, null },
                    { new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), 0, "ec457b43-aa7f-4179-9061-9e2cf4c37eac", "Szakértő állatorvos.", null, false, null, false, null, "Dr. Vakarcs Pál", null, null, null, null, false, null, false, 1, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("1a21d10b-3b18-4165-ba72-c2bd3fc39b20"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("2e008dc3-6dc8-4632-93ef-4a77dc48dadc"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("fdfab8ba-e126-415f-bbed-f9f0276fab95"), new Guid("2e008dc3-6dc8-4632-93ef-4a77dc48dadc") },
                    { new Guid("ff6c74a4-efdb-4ed4-89a6-6a62b6fdd54f"), new Guid("1a21d10b-3b18-4165-ba72-c2bd3fc39b20") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("00109ad6-452f-4848-83ec-15ed7072629b"), 3, "Szerdai rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("1e7c4685-a348-4f83-8dce-fb2b425e7996"), 1, "Általános rendelési idő hétfőn.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("223eb87b-0878-40e1-8468-2e77c151ab8d"), 3, "Szerdai rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("2a037cfb-c931-4046-9155-93f777a97049"), 4, "Csütörtöki rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("4185da50-f91e-486e-acd1-055b7a010c9b"), 5, "Pénteki rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("460234b2-c683-4ccb-aa87-d99b3ae03e65"), 4, "Csütörtöki rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("4b77460e-a04a-4108-9efa-27511bd6fb27"), 4, "Csütörtöki rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("550f88f3-c2ad-4549-b340-6849e236d857"), 3, "Szerdai rövid rendelés.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("5ed7f0a2-9ccf-4432-9a57-bfd262c26e9c"), 3, "Szerdai rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("5f618221-34da-4abf-afd9-922837ff757c"), 1, "Hétfői rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("67095a0a-b9c1-4a77-8cd1-2312e92b7b31"), 5, "Pénteki rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("6ee3e4ee-0af8-43d2-9a96-31b749a7ed38"), 2, "Általános rendelési idő kedden.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("707c18a9-3a8c-4d16-b071-0bd4acc8054f"), 2, "Általános rendelési idő kedden.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("77c4d25a-4451-48ea-9e92-281606a21f69"), 1, "Általános rendelési idő hétfőn.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("7e7d98f9-8700-4630-913d-f275b4538d3d"), 3, "Szerdai rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("7fe1aa78-cf54-4a8c-ad1a-8e95cea0ae70"), 4, "Csütörtöki rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("84cde399-ed4c-433f-ba24-181be8074109"), 2, "Általános rendelési idő kedden.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("8da869b5-f654-42f3-968b-4ddedebdf337"), 5, "Pénteki rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("9b5b81f4-7a2b-485e-82a5-1967340aaec8"), 3, "Szerdai rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("a11773ba-f325-4e4a-8868-7f6648a970bc"), 3, "Szerdai rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("a88f4a14-82e7-437f-9af3-a6b6d3189888"), 4, "Csütörtöki rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("aeff1ab7-f633-4e7a-be25-e03255a7322a"), 5, "Pénteki rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("d0350634-15d9-4229-8e23-9493e3cdedae"), 1, "Általános rendelési idő hétfőn.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("e0002892-001c-4b17-8395-a05c35fb40f6"), 3, "Szerdai rövid rendelés.", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("e6924845-940d-48b3-847c-7f95ed4567de"), 3, "Szerdai rendelés.", new Guid("0a317ff8-ce7f-48b4-9e61-c7a97bd9f3dc"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("e999a369-dbba-4fa2-a689-afb839b47347"), 5, "Pénteki rendelés.", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[,]
                {
                    { new Guid("4a6d5778-1c8c-414d-9fd5-ad16159833b3"), 15000m, new Guid("ff6c74a4-efdb-4ed4-89a6-6a62b6fdd54f"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("c9d476e9-ef43-4b0a-b9dc-b596de49d8b0"), new Guid("1a21d10b-3b18-4165-ba72-c2bd3fc39b20") },
                    { new Guid("d1a02358-3b79-4dd2-a828-b9d58a888c91"), 30000m, new Guid("fdfab8ba-e126-415f-bbed-f9f0276fab95"), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolhaírtás", new Guid("8fa60f46-1914-4e56-966b-f7a5f4d01b25"), new Guid("2e008dc3-6dc8-4632-93ef-4a77dc48dadc") }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("bbe88c8d-0f0d-479d-a388-18f6a4027b67"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("4a6d5778-1c8c-414d-9fd5-ad16159833b3"), 1 });
        }
    }
}
