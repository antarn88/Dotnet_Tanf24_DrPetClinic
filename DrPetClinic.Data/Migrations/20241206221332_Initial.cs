using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Employees_UserId",
                        column: x => x.UserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultationTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Month = table.Column<byte>(type: "tinyint", maxLength: 12, nullable: false),
                    Week = table.Column<byte>(type: "tinyint", maxLength: 53, nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultationTimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimalPerson",
                columns: table => new
                {
                    AnimalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalPerson", x => new { x.AnimalsId, x.OwnersId });
                    table.ForeignKey(
                        name: "FK_AnimalPerson_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalPerson_People_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", precision: 18, scale: 0, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Employees_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Medicine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    HistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entries_Entries_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "Entries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entries_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AnimalPerson_OwnersId",
                table: "AnimalPerson",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationTimes_EmployeeId",
                table: "ConsultationTimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Employees",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Employees",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_HistoryId",
                table: "Entries",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entries_TreatmentId",
                table: "Entries",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_AnimalId",
                table: "Treatments",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DoctorId",
                table: "Treatments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PersonId",
                table: "Treatments",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalPerson");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConsultationTimes");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
