using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1127_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new Guid("5a65f07d-248a-4689-89fe-1d616d3f1227") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new Guid("69ec2894-3913-4e07-83d1-cbba1029fe69") });

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("5ea8b436-22b8-4e47-86e0-11ed0d3d6022"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("07855dd9-80a0-44bf-8a20-945ea2fdc9da"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1ac33d29-a0da-4894-b887-35e710f23b13"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("214afabe-073f-431c-8c0b-587555c12a6d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2773c062-4c9e-46be-b47a-59c5e0d528b4"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("40970431-ddf5-4d68-bcc1-87bc0c44c836"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4fd68afb-11ea-4a32-b06d-d9aa230afcf4"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("52bbf70e-9476-457c-a3c6-8ba85579d92e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5b05ab26-ce5b-4a22-8462-505d4dc771bf"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("623560ee-cbba-45a0-bf6a-de2ea5034eb6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("650b3745-d439-4e8c-914b-ac9c466a1546"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("69c33096-379d-4c75-8fec-1be6b844ce81"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("7d0c5f24-ab9a-4128-ac3e-9ddedd30b5ab"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("866adfff-1eb8-40ef-8745-ad1f45250912"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8c351edc-a20c-4517-8161-8745b8a018eb"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9f94e21f-c43d-41bb-8d1e-408b9b0cb617"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a60ef0eb-da9d-485b-8041-933cb05c76ba"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("abdcaaae-4a2b-437c-bbbe-b52d43c3ce67"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ace2f6b5-843d-4d13-bcb7-9f20dfdb9525"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("af12e88a-553e-423f-ba30-a4c8a8cc999a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b4800386-1461-4fce-b26e-60a1c5d5d7c3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bd03c7d6-d5a1-487c-bbdd-48d1fd4c483c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("be9503aa-9034-4c5d-989b-81e6fb50f7cf"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d0f5991a-b39a-4132-890f-34f008bc4b10"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d1957db8-94ea-4c31-9764-d9ee065641b7"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e12f3e27-1f75-4119-bb39-bcfe5e7a1e2b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e1460288-2ee7-46a8-923e-fa558d9d943f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8c1b879e-2b51-4da9-91eb-320b78da270b"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("8c44ce71-63cf-4296-b51a-17970904c138"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("5a65f07d-248a-4689-89fe-1d616d3f1227"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("03b4df59-6c0d-4aba-b6fa-96a9143ef1fb"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85ae2572-983e-4863-af38-afa503cd8d95"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("69ec2894-3913-4e07-83d1-cbba1029fe69"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("0aa53440-cc64-4321-8906-c3f83c0a974a"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("e89ff0f6-39d1-44ed-84fc-76b44d695a08"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("36066897-b9ca-416a-9608-2361f98c8711"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 },
                    { new Guid("65634831-0098-4472-9d6d-a0ff5a2c2bfd"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("34a410a5-165f-43f1-89ca-1d5a0619b4b0"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("c7e0e401-6e89-439f-a4e7-ba47118eb789"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("0aa53440-cc64-4321-8906-c3f83c0a974a"), new Guid("c7e0e401-6e89-439f-a4e7-ba47118eb789") },
                    { new Guid("e89ff0f6-39d1-44ed-84fc-76b44d695a08"), new Guid("34a410a5-165f-43f1-89ca-1d5a0619b4b0") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("03b5b8b1-8275-487a-8830-342574414208"), 1, "Általános rendelési idő hétfőn.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("06093548-864b-4b23-8082-ff5eab3be5e7"), 3, "Szerdai rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("09d3d346-76be-4e82-986e-6f7556bcf970"), 2, "Általános rendelési idő kedden.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("135d9b4e-402a-4a4b-8e1b-cb4035d60ef0"), 4, "Csütörtöki rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("18808561-d030-4d78-853e-f7a110877789"), 4, "Csütörtöki rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("1ab429f5-7735-4f1b-99c4-065913a3c92f"), 2, "Általános rendelési idő kedden.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("2f829fa5-4ad7-43d1-8b71-660a23467848"), 5, "Pénteki rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("41d1f9d0-4c5d-46d9-a90d-cf0b8469102b"), 3, "Szerdai rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("539e725b-008e-4f23-874e-14cab2c358af"), 3, "Szerdai rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("5ff6f9e8-2b59-4557-9d2f-b4f833ceb98c"), 5, "Pénteki rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("62546410-e0d7-4a2d-ad59-40844bdfcab5"), 3, "Szerdai rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("631c7159-8b8b-4fe8-98b7-0b42f476963e"), 1, "Általános rendelési idő hétfőn.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("6598c657-e117-46fe-a303-87fcb96e9ceb"), 4, "Csütörtöki rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("6c00c3e3-bdf4-4f7f-8a12-5ff90ed366b5"), 4, "Csütörtöki rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("78d0e0ff-b624-445a-9ea0-e9a22390b6aa"), 3, "Szerdai rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("79bbefd1-81f1-4231-bd59-ffa55547c10e"), 1, "Hétfői rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("84018474-6d27-42ad-a8ae-d2b01fc10a1d"), 3, "Szerdai rövid rendelés.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("91807d57-9493-4d12-87ec-91d75cacda31"), 3, "Szerdai rövid rendelés.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("962a8a83-4d62-4ae6-afd3-5f14367ebf85"), 3, "Szerdai rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("984693c5-aac7-4364-8881-2c1a19422db8"), 1, "Általános rendelési idő hétfőn.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("a2916a45-b1fa-4b1d-8a44-dcbb46b830cf"), 5, "Pénteki rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("ab7c82b8-9537-4702-8d4b-04e522891474"), 2, "Általános rendelési idő kedden.", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("cdf791e6-6df4-4189-a501-c17c9d3ce4ba"), 5, "Pénteki rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("cf8a1b92-7e52-45f7-9f4e-04c3a777cc96"), 5, "Pénteki rendelés.", new Guid("36066897-b9ca-416a-9608-2361f98c8711"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("eee17568-c810-4a1c-9ff0-2f37e6bd17fe"), 3, "Szerdai rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("fe380ef2-6c5f-4a00-8cd3-53c3933c7c51"), 4, "Csütörtöki rendelés.", new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("8f26559f-aebc-4c5a-a4fd-6232b9d0154f"), 15000m, new Guid("e89ff0f6-39d1-44ed-84fc-76b44d695a08"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"), new Guid("34a410a5-165f-43f1-89ca-1d5a0619b4b0") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("5cdabc3c-18df-48ed-9c0a-a58dbe187d10"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("8f26559f-aebc-4c5a-a4fd-6232b9d0154f"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("0aa53440-cc64-4321-8906-c3f83c0a974a"), new Guid("c7e0e401-6e89-439f-a4e7-ba47118eb789") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("e89ff0f6-39d1-44ed-84fc-76b44d695a08"), new Guid("34a410a5-165f-43f1-89ca-1d5a0619b4b0") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("03b5b8b1-8275-487a-8830-342574414208"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("06093548-864b-4b23-8082-ff5eab3be5e7"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("09d3d346-76be-4e82-986e-6f7556bcf970"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("135d9b4e-402a-4a4b-8e1b-cb4035d60ef0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("18808561-d030-4d78-853e-f7a110877789"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1ab429f5-7735-4f1b-99c4-065913a3c92f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2f829fa5-4ad7-43d1-8b71-660a23467848"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("41d1f9d0-4c5d-46d9-a90d-cf0b8469102b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("539e725b-008e-4f23-874e-14cab2c358af"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("5ff6f9e8-2b59-4557-9d2f-b4f833ceb98c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("62546410-e0d7-4a2d-ad59-40844bdfcab5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("631c7159-8b8b-4fe8-98b7-0b42f476963e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6598c657-e117-46fe-a303-87fcb96e9ceb"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("6c00c3e3-bdf4-4f7f-8a12-5ff90ed366b5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("78d0e0ff-b624-445a-9ea0-e9a22390b6aa"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("79bbefd1-81f1-4231-bd59-ffa55547c10e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("84018474-6d27-42ad-a8ae-d2b01fc10a1d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("91807d57-9493-4d12-87ec-91d75cacda31"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("962a8a83-4d62-4ae6-afd3-5f14367ebf85"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("984693c5-aac7-4364-8881-2c1a19422db8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("a2916a45-b1fa-4b1d-8a44-dcbb46b830cf"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ab7c82b8-9537-4702-8d4b-04e522891474"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("cdf791e6-6df4-4189-a501-c17c9d3ce4ba"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("cf8a1b92-7e52-45f7-9f4e-04c3a777cc96"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("eee17568-c810-4a1c-9ff0-2f37e6bd17fe"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fe380ef2-6c5f-4a00-8cd3-53c3933c7c51"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("65634831-0098-4472-9d6d-a0ff5a2c2bfd"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("5cdabc3c-18df-48ed-9c0a-a58dbe187d10"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("0aa53440-cc64-4321-8906-c3f83c0a974a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("287e9c90-dc34-4461-aef5-1f6bd7ecf753"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("36066897-b9ca-416a-9608-2361f98c8711"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("c7e0e401-6e89-439f-a4e7-ba47118eb789"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("8f26559f-aebc-4c5a-a4fd-6232b9d0154f"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e89ff0f6-39d1-44ed-84fc-76b44d695a08"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("af5702fd-b06e-4560-8bad-cfe44b60eb14"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("34a410a5-165f-43f1-89ca-1d5a0619b4b0"));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("5ea8b436-22b8-4e47-86e0-11ed0d3d6022"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("8c1b879e-2b51-4da9-91eb-320b78da270b"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("5a65f07d-248a-4689-89fe-1d616d3f1227"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("69ec2894-3913-4e07-83d1-cbba1029fe69"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new Guid("5a65f07d-248a-4689-89fe-1d616d3f1227") },
                    { new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new Guid("69ec2894-3913-4e07-83d1-cbba1029fe69") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("07855dd9-80a0-44bf-8a20-945ea2fdc9da"), 3, "Szerdai rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("1ac33d29-a0da-4894-b887-35e710f23b13"), 1, "Általános rendelési idő hétfőn.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("214afabe-073f-431c-8c0b-587555c12a6d"), 3, "Szerdai rövid rendelés.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("2773c062-4c9e-46be-b47a-59c5e0d528b4"), 3, "Szerdai rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("40970431-ddf5-4d68-bcc1-87bc0c44c836"), 3, "Szerdai rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("4fd68afb-11ea-4a32-b06d-d9aa230afcf4"), 5, "Pénteki rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("52bbf70e-9476-457c-a3c6-8ba85579d92e"), 4, "Csütörtöki rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("5b05ab26-ce5b-4a22-8462-505d4dc771bf"), 4, "Csütörtöki rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("623560ee-cbba-45a0-bf6a-de2ea5034eb6"), 1, "Általános rendelési idő hétfőn.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("650b3745-d439-4e8c-914b-ac9c466a1546"), 2, "Általános rendelési idő kedden.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("69c33096-379d-4c75-8fec-1be6b844ce81"), 4, "Csütörtöki rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("7d0c5f24-ab9a-4128-ac3e-9ddedd30b5ab"), 2, "Általános rendelési idő kedden.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("866adfff-1eb8-40ef-8745-ad1f45250912"), 4, "Csütörtöki rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("8c351edc-a20c-4517-8161-8745b8a018eb"), 5, "Pénteki rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("9f94e21f-c43d-41bb-8d1e-408b9b0cb617"), 3, "Szerdai rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("a60ef0eb-da9d-485b-8041-933cb05c76ba"), 1, "Általános rendelési idő hétfőn.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("abdcaaae-4a2b-437c-bbbe-b52d43c3ce67"), 2, "Általános rendelési idő kedden.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("ace2f6b5-843d-4d13-bcb7-9f20dfdb9525"), 3, "Szerdai rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("af12e88a-553e-423f-ba30-a4c8a8cc999a"), 5, "Pénteki rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("b4800386-1461-4fce-b26e-60a1c5d5d7c3"), 3, "Szerdai rövid rendelés.", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("bd03c7d6-d5a1-487c-bbdd-48d1fd4c483c"), 3, "Szerdai rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("be9503aa-9034-4c5d-989b-81e6fb50f7cf"), 1, "Hétfői rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("d0f5991a-b39a-4132-890f-34f008bc4b10"), 3, "Szerdai rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("d1957db8-94ea-4c31-9764-d9ee065641b7"), 4, "Csütörtöki rendelés.", new Guid("8688b0e7-ed5f-4858-8cc5-38d791527f56"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("e12f3e27-1f75-4119-bb39-bcfe5e7a1e2b"), 5, "Pénteki rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("e1460288-2ee7-46a8-923e-fa558d9d943f"), 5, "Pénteki rendelés.", new Guid("de29074d-ea91-46e0-9d79-87bdbccb8a99"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("03b4df59-6c0d-4aba-b6fa-96a9143ef1fb"), 15000m, new Guid("3443bbcd-63d1-4a22-be7d-98021a04e7a4"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("85ae2572-983e-4863-af38-afa503cd8d95"), new Guid("69ec2894-3913-4e07-83d1-cbba1029fe69") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("8c44ce71-63cf-4296-b51a-17970904c138"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("03b4df59-6c0d-4aba-b6fa-96a9143ef1fb"), 1 });
        }
    }
}
