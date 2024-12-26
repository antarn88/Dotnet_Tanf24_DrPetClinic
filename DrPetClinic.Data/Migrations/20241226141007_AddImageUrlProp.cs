using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("e5b895bc-ff80-4d0f-995c-278bf9066dd9"), new Guid("a119318e-0358-4f88-8e5e-177898786f33") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("fd5e2324-3643-4e65-b8f0-4585f720b9c0"), new Guid("7e44d874-d95e-454b-a45d-e98da176a495") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("056d2f53-3ce3-44af-981d-825ba6f19316"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0a46b308-3896-4ec8-84bf-6dae2a23c81d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("223c7e6f-207e-4ed1-95fa-3e3ee68d4886"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2842ee10-8e74-4189-a7b2-37948fb8c87d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("28f9090b-fc7b-46be-a197-7962acfbda09"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2a64b4d0-90fa-4935-b2cb-2ac404c2d05b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2c89792d-8f8e-4655-a774-dc61d16cfb0f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("333c7c44-acdd-42a6-b2fc-31d35243edad"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3a3d41c2-97a4-4212-813c-012c68e8cf52"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4861f558-e7cd-4b47-ae44-740bbc621fd0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4def4b4a-a756-495e-8f94-1983a5f890ca"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("58a16dca-38e2-4dc0-85f8-7321f9d69201"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6bfa5ad7-a92a-48c2-9f0f-5bf77b1c6b3e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9461b5ef-0db2-4f68-af86-5dc3110c65d4"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a21827a3-db4a-4987-9d30-09d35450f0a6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b601a9ca-b7c7-4b98-9661-4d37a397f2fc"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b6d264e0-f83d-41a6-b4a0-07d17d519a6f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bcd22834-345e-43e0-a373-8cd7455d6a31"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bf264222-47bd-48a4-8baf-ab296f186553"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c9bebc3e-ed3e-4e9e-83a3-6d596dd30d64"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e338f456-e391-48f9-826d-1e5118379185"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e83c77ec-5f76-4c04-bd3b-8837a682100a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ede20d29-3835-4dd0-ac2a-7f9953bc5f45"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ef4e3cea-bff8-47f9-8861-099814f65c09"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f5339ded-9fba-4eb2-993b-98b097d7e14f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fa116be2-c806-4195-9cc7-c624ea64a1c2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("826ae895-d372-42bf-906d-58442bd5ac15"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("f46357ab-8580-4dab-b3eb-4801cd6713c1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("828467b2-7661-4bf2-9a2b-f1fe99129740"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("fd5e2324-3643-4e65-b8f0-4585f720b9c0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6898af95-0627-4231-8230-f250725e8616"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("7e44d874-d95e-454b-a45d-e98da176a495"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("11b0cfe5-2493-49f0-81e0-2641860de353"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e5b895bc-ff80-4d0f-995c-278bf9066dd9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a119318e-0358-4f88-8e5e-177898786f33"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("e5b895bc-ff80-4d0f-995c-278bf9066dd9"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("fd5e2324-3643-4e65-b8f0-4585f720b9c0"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { new Guid("6898af95-0627-4231-8230-f250725e8616"), 0, "dc2532d2-d87e-417f-8d58-798c84c8a666", "Sebész specialista.", null, false, false, null, "Dr. Szabó Éva", null, null, null, null, false, null, false, 1, null },
                    { new Guid("826ae895-d372-42bf-906d-58442bd5ac15"), 0, "49176edf-7301-4094-bfa8-392de02765a0", "A klinika segédje, minden munkában ott van.", null, false, false, null, "Hajdu Eszter", null, null, null, null, false, null, false, 2, null },
                    { new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), 0, "047c49b8-3675-4653-9e59-0f81bf5bd32e", "Szakértő állatorvos.", null, false, false, null, "Dr. Vakarcs Pál", null, null, null, null, false, null, false, 1, null },
                    { new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), 0, "dbc1baa3-b440-4c1f-a4d0-d4aa1ac03a3d", "Egzotikus állatok szakértője.", null, false, false, null, "Dr. Kiss Tamás", null, null, null, null, false, null, false, 1, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("7e44d874-d95e-454b-a45d-e98da176a495"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("a119318e-0358-4f88-8e5e-177898786f33"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("e5b895bc-ff80-4d0f-995c-278bf9066dd9"), new Guid("a119318e-0358-4f88-8e5e-177898786f33") },
                    { new Guid("fd5e2324-3643-4e65-b8f0-4585f720b9c0"), new Guid("7e44d874-d95e-454b-a45d-e98da176a495") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("056d2f53-3ce3-44af-981d-825ba6f19316"), 5, "Pénteki rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("0a46b308-3896-4ec8-84bf-6dae2a23c81d"), 4, "Csütörtöki rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("223c7e6f-207e-4ed1-95fa-3e3ee68d4886"), 3, "Szerdai rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("2842ee10-8e74-4189-a7b2-37948fb8c87d"), 3, "Szerdai rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("28f9090b-fc7b-46be-a197-7962acfbda09"), 5, "Pénteki rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("2a64b4d0-90fa-4935-b2cb-2ac404c2d05b"), 2, "Általános rendelési idő kedden.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("2c89792d-8f8e-4655-a774-dc61d16cfb0f"), 3, "Szerdai rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("333c7c44-acdd-42a6-b2fc-31d35243edad"), 5, "Pénteki rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("3a3d41c2-97a4-4212-813c-012c68e8cf52"), 4, "Csütörtöki rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("4861f558-e7cd-4b47-ae44-740bbc621fd0"), 3, "Szerdai rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("4def4b4a-a756-495e-8f94-1983a5f890ca"), 3, "Szerdai rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("58a16dca-38e2-4dc0-85f8-7321f9d69201"), 1, "Általános rendelési idő hétfőn.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("6bfa5ad7-a92a-48c2-9f0f-5bf77b1c6b3e"), 3, "Szerdai rövid rendelés.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("9461b5ef-0db2-4f68-af86-5dc3110c65d4"), 1, "Általános rendelési idő hétfőn.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("a21827a3-db4a-4987-9d30-09d35450f0a6"), 4, "Csütörtöki rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("b601a9ca-b7c7-4b98-9661-4d37a397f2fc"), 3, "Szerdai rövid rendelés.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("b6d264e0-f83d-41a6-b4a0-07d17d519a6f"), 4, "Csütörtöki rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("bcd22834-345e-43e0-a373-8cd7455d6a31"), 5, "Pénteki rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("bf264222-47bd-48a4-8baf-ab296f186553"), 2, "Általános rendelési idő kedden.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("c9bebc3e-ed3e-4e9e-83a3-6d596dd30d64"), 3, "Szerdai rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("e338f456-e391-48f9-826d-1e5118379185"), 1, "Hétfői rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("e83c77ec-5f76-4c04-bd3b-8837a682100a"), 1, "Általános rendelési idő hétfőn.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("ede20d29-3835-4dd0-ac2a-7f9953bc5f45"), 2, "Általános rendelési idő kedden.", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("ef4e3cea-bff8-47f9-8861-099814f65c09"), 3, "Szerdai rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("f5339ded-9fba-4eb2-993b-98b097d7e14f"), 4, "Csütörtöki rendelés.", new Guid("6898af95-0627-4231-8230-f250725e8616"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("fa116be2-c806-4195-9cc7-c624ea64a1c2"), 5, "Pénteki rendelés.", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[,]
                {
                    { new Guid("11b0cfe5-2493-49f0-81e0-2641860de353"), 15000m, new Guid("e5b895bc-ff80-4d0f-995c-278bf9066dd9"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("dfa8be9a-12aa-4ea8-9cb5-cbc60522c627"), new Guid("a119318e-0358-4f88-8e5e-177898786f33") },
                    { new Guid("828467b2-7661-4bf2-9a2b-f1fe99129740"), 30000m, new Guid("fd5e2324-3643-4e65-b8f0-4585f720b9c0"), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolhaírtás", new Guid("e1f1af91-f613-4420-8f4d-a7acf0560b89"), new Guid("7e44d874-d95e-454b-a45d-e98da176a495") }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("f46357ab-8580-4dab-b3eb-4801cd6713c1"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("11b0cfe5-2493-49f0-81e0-2641860de353"), 1 });
        }
    }
}
