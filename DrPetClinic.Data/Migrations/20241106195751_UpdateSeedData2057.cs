using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData2057 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("e7b89889-83ea-4b00-8e9c-96d2d76de738"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("47caa033-d855-48f7-9cb1-07aeff1db2d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("584a47e1-1a49-4ce7-a786-9137ddba4490"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("d4c14f6e-4168-4074-918a-4fea84f94254"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("4595696c-1036-409e-b8ca-7be653bee204"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("df99b360-33c8-4f35-816f-5561fb83ba67"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("d73e2118-4f6d-4719-a265-b90c50369ead"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("f5bf810c-a032-4a08-8a42-aa2de50d17ec"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("d73e2118-4f6d-4719-a265-b90c50369ead"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("e7b89889-83ea-4b00-8e9c-96d2d76de738"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { new Guid("584a47e1-1a49-4ce7-a786-9137ddba4490"), "A klinika segédje, minden munkában ott van.", "Hajdu Eszter", 2 },
                    { new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"), "Szakértő állatorvos.", "Dr. Vakarcs Pál", 1 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("4595696c-1036-409e-b8ca-7be653bee204"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" },
                    { new Guid("f5bf810c-a032-4a08-8a42-aa2de50d17ec"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[] { new Guid("47caa033-d855-48f7-9cb1-07aeff1db2d5"), 1, "Általános rendelési idő hétfőn.", new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)10, new TimeSpan(0, 9, 0, 0, 0), (byte)1, (short)2023 });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[] { new Guid("df99b360-33c8-4f35-816f-5561fb83ba67"), 15000m, new Guid("d73e2118-4f6d-4719-a265-b90c50369ead"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("e2ecce8e-9bbe-4ea8-9678-cef23f7b6ca4"), new Guid("f5bf810c-a032-4a08-8a42-aa2de50d17ec") });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("d4c14f6e-4168-4074-918a-4fea84f94254"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("df99b360-33c8-4f35-816f-5561fb83ba67"), 1 });
        }
    }
}
