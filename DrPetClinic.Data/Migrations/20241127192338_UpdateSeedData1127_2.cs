using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1127_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new Guid("4fb9aacd-1f0a-43bd-bb76-ee4133286742") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new Guid("a0a26c8f-fe7d-420a-a7b6-f3172ae1c74a") });

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("690e557d-ae87-4bf7-b973-29447bcd1af3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0d2be591-29cd-4611-b054-bfeefb82b0ec"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("127bfadb-87d4-4360-82af-5af3d2dc511c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("161c0aea-c7f4-48fc-8bfc-68d81eec309c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("34b4e0a4-d688-459c-8226-3a363e1e933d"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("419d30b6-a794-417d-b0c4-cca602162248"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("4902840b-e734-4bb8-a204-679b2d627848"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("496ca440-99b0-49f2-b415-f8d32a0eee64"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("528c98e6-2f07-4a93-92f9-05aa5037cbfb"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("59ec5b13-be21-4cfe-9fd6-4b96736b11b3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8568eb19-bfa4-47a3-844a-3df4d60dcfbc"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("8adc2d38-ee4d-4846-8174-7dff97f1fd89"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("91bfc85a-e17b-4849-9afa-e5f94283f939"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("9d8c487d-c31a-4ed7-ba77-116b4ca7aeb8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ad7d84b8-9ced-426d-96d8-99803b7e0e20"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b3d1ba90-9124-4ffe-8f4a-2055e79304c9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b976b97a-c348-4f91-9562-2d56f760e8d8"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bc591e95-fdaa-4f92-8845-3aa192203cfa"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bd58c5aa-077c-49ee-a165-cb329ab37b79"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("bff13021-49e5-431f-814f-33ea7f5ed330"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("cee1a90a-a8c8-4035-a922-fad71d55a203"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d6f3f16f-b727-41ba-b317-b562de998be0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("dd50b591-8919-4396-ba99-49e394454851"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e69fd438-8d86-455a-b2ca-54b8e153d2b9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f75a4f7a-80a0-43e9-b0a4-ed30aa7afaae"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f835629d-7258-43ca-9771-bd7ebd23e5a9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f86ef2e0-176f-47df-af1f-3f1375b4ec9b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e3087928-fdfc-40fd-847e-b3dc11667e87"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("cd953cfa-5133-40b7-8788-eaf0ff7dc85d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("a0a26c8f-fe7d-420a-a7b6-f3172ae1c74a"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("59972db8-6eaf-4851-9e76-c41c5faed427"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("37dea723-1f02-4c40-a36b-8a439564c375"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("4fb9aacd-1f0a-43bd-bb76-ee4133286742"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("690e557d-ae87-4bf7-b973-29447bcd1af3"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), "Egzotikus állatok szakértője.", "Dr. Kiss Tamás", 1 },
                    { new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("e3087928-fdfc-40fd-847e-b3dc11667e87"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), "Sebész specialista.", "Dr. Szabó Éva", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("4fb9aacd-1f0a-43bd-bb76-ee4133286742"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("a0a26c8f-fe7d-420a-a7b6-f3172ae1c74a"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new Guid("4fb9aacd-1f0a-43bd-bb76-ee4133286742") },
                    { new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new Guid("a0a26c8f-fe7d-420a-a7b6-f3172ae1c74a") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("0d2be591-29cd-4611-b054-bfeefb82b0ec"), 1, "Általános rendelési idő hétfőn.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("127bfadb-87d4-4360-82af-5af3d2dc511c"), 2, "Általános rendelési idő kedden.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("161c0aea-c7f4-48fc-8bfc-68d81eec309c"), 3, "Szerdai rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("34b4e0a4-d688-459c-8226-3a363e1e933d"), 3, "Szerdai rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("419d30b6-a794-417d-b0c4-cca602162248"), 5, "Pénteki rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("4902840b-e734-4bb8-a204-679b2d627848"), 4, "Csütörtöki rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("496ca440-99b0-49f2-b415-f8d32a0eee64"), 1, "Általános rendelési idő hétfőn.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("528c98e6-2f07-4a93-92f9-05aa5037cbfb"), 4, "Csütörtöki rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("59ec5b13-be21-4cfe-9fd6-4b96736b11b3"), 3, "Szerdai rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("8568eb19-bfa4-47a3-844a-3df4d60dcfbc"), 5, "Pénteki rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("8adc2d38-ee4d-4846-8174-7dff97f1fd89"), 3, "Szerdai rövid rendelés.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("91bfc85a-e17b-4849-9afa-e5f94283f939"), 4, "Csütörtöki rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("9d8c487d-c31a-4ed7-ba77-116b4ca7aeb8"), 5, "Pénteki rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("ad7d84b8-9ced-426d-96d8-99803b7e0e20"), 3, "Szerdai rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("b3d1ba90-9124-4ffe-8f4a-2055e79304c9"), 1, "Általános rendelési idő hétfőn.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("b976b97a-c348-4f91-9562-2d56f760e8d8"), 3, "Szerdai rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("bc591e95-fdaa-4f92-8845-3aa192203cfa"), 5, "Pénteki rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("bd58c5aa-077c-49ee-a165-cb329ab37b79"), 3, "Szerdai rövid rendelés.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("bff13021-49e5-431f-814f-33ea7f5ed330"), 3, "Szerdai rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("cee1a90a-a8c8-4035-a922-fad71d55a203"), 3, "Szerdai rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("d6f3f16f-b727-41ba-b317-b562de998be0"), 4, "Csütörtöki rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("dd50b591-8919-4396-ba99-49e394454851"), 5, "Pénteki rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("e69fd438-8d86-455a-b2ca-54b8e153d2b9"), 1, "Hétfői rendelés.", new Guid("a785cc35-a3d5-411f-b4df-d9406a7725e6"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("f75a4f7a-80a0-43e9-b0a4-ed30aa7afaae"), 4, "Csütörtöki rendelés.", new Guid("e6e59ce8-887c-4851-9b94-27db34f29ea8"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("f835629d-7258-43ca-9771-bd7ebd23e5a9"), 2, "Általános rendelési idő kedden.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("f86ef2e0-176f-47df-af1f-3f1375b4ec9b"), 2, "Általános rendelési idő kedden.", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("59972db8-6eaf-4851-9e76-c41c5faed427"), 15000m, new Guid("37dea723-1f02-4c40-a36b-8a439564c375"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("c0235c2e-8caf-456a-ad3c-99b7d52ffba7"), new Guid("4fb9aacd-1f0a-43bd-bb76-ee4133286742") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("cd953cfa-5133-40b7-8788-eaf0ff7dc85d"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("59972db8-6eaf-4851-9e76-c41c5faed427"), 1 });
        }
    }
}
