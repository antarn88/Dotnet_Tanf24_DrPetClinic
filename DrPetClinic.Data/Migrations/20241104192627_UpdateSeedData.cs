﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("67df453c-c08d-492c-93cf-53cda281e7d0"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" },
                    { new Guid("e1a58661-2023-4132-98fd-ff4663f18ab6"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 },
                    { new Guid("c5b01d5e-68e5-40d0-930e-47dbb1ad1af5"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("31dc8872-2813-4c3b-976b-54422d122611"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("49b5714e-c1b2-4a45-af0b-14de38f751db"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[] { new Guid("2904afbd-e2d0-4e95-9f19-e78d92089802"), 1, "Általános rendelési idő hétfőn.", new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)10, new TimeSpan(0, 9, 0, 0, 0), (byte)1, (short)2023 });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("82f241ba-e5ef-47d6-a494-452630e2c953"), 15000m, new Guid("e1a58661-2023-4132-98fd-ff4663f18ab6"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"), new Guid("31dc8872-2813-4c3b-976b-54422d122611") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("a5768f27-78b5-41b0-9583-3ab37a7c6a51"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("82f241ba-e5ef-47d6-a494-452630e2c953"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("67df453c-c08d-492c-93cf-53cda281e7d0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2904afbd-e2d0-4e95-9f19-e78d92089802"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c5b01d5e-68e5-40d0-930e-47dbb1ad1af5"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("a5768f27-78b5-41b0-9583-3ab37a7c6a51"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("49b5714e-c1b2-4a45-af0b-14de38f751db"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("82f241ba-e5ef-47d6-a494-452630e2c953"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e1a58661-2023-4132-98fd-ff4663f18ab6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("34fbb070-ab45-41e9-be6c-c6367c0e1328"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("31dc8872-2813-4c3b-976b-54422d122611"));
        }
    }
}
