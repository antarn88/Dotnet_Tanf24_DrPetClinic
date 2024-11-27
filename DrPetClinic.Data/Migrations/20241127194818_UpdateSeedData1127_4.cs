using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1127_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("916c6744-d279-4e22-82e2-8cc3dadf5046"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("dfaaef8b-0acc-4e37-bf8d-6912d1c85ec0"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), "Sebész specialista.", "Dr. Szabó Éva", 1 },
                    { new Guid("4eb83681-05d8-4e94-a915-2c59ff8eb2fd"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 },
                    { new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("15511172-14ae-4a10-890f-4f74eb20ea4d"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("f959abc7-c754-4c1a-b7cb-6f20a672e606"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("916c6744-d279-4e22-82e2-8cc3dadf5046"), new Guid("f959abc7-c754-4c1a-b7cb-6f20a672e606") },
                    { new Guid("dfaaef8b-0acc-4e37-bf8d-6912d1c85ec0"), new Guid("15511172-14ae-4a10-890f-4f74eb20ea4d") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("006e0fb6-9996-430c-88e3-3e38841d94e8"), 4, "Csütörtöki rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("02403e78-a9ed-4bad-a5d4-4a8725826ee9"), 5, "Pénteki rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("04a56552-c94c-42b6-b731-753d93c3b244"), 4, "Csütörtöki rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("11f2ac6c-a99c-4295-90c3-a6f48c533e71"), 1, "Általános rendelési idő hétfőn.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("1c12d42c-af56-49a0-a1a0-56598cfd4caf"), 2, "Általános rendelési idő kedden.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("1c1e7a1c-d3df-447f-b5bb-b9a1c0b791a7"), 5, "Pénteki rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("2a96f49e-d691-4c0c-9382-7aa11041ee6e"), 3, "Szerdai rövid rendelés.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("3435bd82-e8b8-42a9-95c8-100445c1e8ec"), 4, "Csütörtöki rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("3e120f17-4dab-4153-bd60-9186b5aa568d"), 2, "Általános rendelési idő kedden.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("4b7bf13c-8581-4748-9142-5f101b55c3ba"), 5, "Pénteki rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("569d37e3-d8e7-43f0-82c2-b2b75298d8c7"), 3, "Szerdai rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("8769f6e4-de12-478e-b059-5e205f9d57b8"), 4, "Csütörtöki rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("8a2ccb9e-9928-4b75-8a6a-6c7b19b26c71"), 3, "Szerdai rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("9338ffa4-df29-45ad-a3a7-35e03f3ab9da"), 3, "Szerdai rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("9354fde8-1d10-4499-bc3e-16201720e39f"), 1, "Hétfői rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("cc3052c9-f2e1-40dc-8e8e-09776d37c0e8"), 3, "Szerdai rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("ce32b021-8300-4787-87e7-716513010dbd"), 4, "Csütörtöki rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("d16c39e3-b327-4aaf-b3b0-224760cb68b3"), 5, "Pénteki rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("d4707553-c785-47e3-9e68-4a967f8d2c66"), 1, "Általános rendelési idő hétfőn.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("dbae9501-ac05-42c1-a4bd-b874f9d18646"), 3, "Szerdai rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("e13334c9-1d08-431f-bbfc-93c8f0096fa9"), 1, "Általános rendelési idő hétfőn.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("eb076791-e842-4635-8b4d-cb9c7b3f8292"), 2, "Általános rendelési idő kedden.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("ebe59e29-5b80-4205-bac3-73915e25022f"), 3, "Szerdai rendelés.", new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("f8538c35-1790-4bc0-8250-ce7d01a586e3"), 5, "Pénteki rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("fbd108b9-622b-4004-af24-916ec27d0689"), 3, "Szerdai rövid rendelés.", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("fc2f1d23-62e8-4ad7-81b7-d14938fd3ace"), 3, "Szerdai rendelés.", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[,]
                {
                    { new Guid("32e46239-0009-4d81-9242-2382cbae6127"), 30000m, new Guid("916c6744-d279-4e22-82e2-8cc3dadf5046"), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolhaírtás", new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"), new Guid("f959abc7-c754-4c1a-b7cb-6f20a672e606") },
                    { new Guid("4556aa1a-bc3f-4fdd-a1ba-e28a6072d214"), 15000m, new Guid("dfaaef8b-0acc-4e37-bf8d-6912d1c85ec0"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"), new Guid("15511172-14ae-4a10-890f-4f74eb20ea4d") }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("398522a6-0b7b-47e7-aaf7-c8f32bc19020"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("4556aa1a-bc3f-4fdd-a1ba-e28a6072d214"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("916c6744-d279-4e22-82e2-8cc3dadf5046"), new Guid("f959abc7-c754-4c1a-b7cb-6f20a672e606") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("dfaaef8b-0acc-4e37-bf8d-6912d1c85ec0"), new Guid("15511172-14ae-4a10-890f-4f74eb20ea4d") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("006e0fb6-9996-430c-88e3-3e38841d94e8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("02403e78-a9ed-4bad-a5d4-4a8725826ee9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("04a56552-c94c-42b6-b731-753d93c3b244"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("11f2ac6c-a99c-4295-90c3-a6f48c533e71"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1c12d42c-af56-49a0-a1a0-56598cfd4caf"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1c1e7a1c-d3df-447f-b5bb-b9a1c0b791a7"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2a96f49e-d691-4c0c-9382-7aa11041ee6e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3435bd82-e8b8-42a9-95c8-100445c1e8ec"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("3e120f17-4dab-4153-bd60-9186b5aa568d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4b7bf13c-8581-4748-9142-5f101b55c3ba"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("569d37e3-d8e7-43f0-82c2-b2b75298d8c7"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8769f6e4-de12-478e-b059-5e205f9d57b8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8a2ccb9e-9928-4b75-8a6a-6c7b19b26c71"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9338ffa4-df29-45ad-a3a7-35e03f3ab9da"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9354fde8-1d10-4499-bc3e-16201720e39f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("cc3052c9-f2e1-40dc-8e8e-09776d37c0e8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ce32b021-8300-4787-87e7-716513010dbd"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d16c39e3-b327-4aaf-b3b0-224760cb68b3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d4707553-c785-47e3-9e68-4a967f8d2c66"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("dbae9501-ac05-42c1-a4bd-b874f9d18646"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e13334c9-1d08-431f-bbfc-93c8f0096fa9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("eb076791-e842-4635-8b4d-cb9c7b3f8292"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ebe59e29-5b80-4205-bac3-73915e25022f"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f8538c35-1790-4bc0-8250-ce7d01a586e3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fbd108b9-622b-4004-af24-916ec27d0689"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("fc2f1d23-62e8-4ad7-81b7-d14938fd3ace"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4eb83681-05d8-4e94-a915-2c59ff8eb2fd"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("398522a6-0b7b-47e7-aaf7-c8f32bc19020"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("32e46239-0009-4d81-9242-2382cbae6127"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("916c6744-d279-4e22-82e2-8cc3dadf5046"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("14fff1da-2f95-4823-8e6e-b7f51a33807a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8dcbcaf3-7ea7-410f-a7c3-fe3288ddf8e2"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("f959abc7-c754-4c1a-b7cb-6f20a672e606"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("4556aa1a-bc3f-4fdd-a1ba-e28a6072d214"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("dfaaef8b-0acc-4e37-bf8d-6912d1c85ec0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c1b002c7-50f1-4622-8418-c2b94397ac06"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("15511172-14ae-4a10-890f-4f74eb20ea4d"));

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
    }
}
