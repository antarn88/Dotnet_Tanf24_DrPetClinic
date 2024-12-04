using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Employees",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Employees",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Employees",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Species", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("37ee9f58-a30c-4c9a-9e10-8b5b9dadef91"), new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ő a falu legszorgalmasabb terelője.", "Bodri", "Kutya", "Jó egészségnek örvend", "Puli" },
                    { new Guid("a49d8156-ac7e-4607-a0e7-fed4c5584cbf"), new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A kajáért él-hal, de csak akkor enged közel, ha akar.", "Cirmi", "Macska", "Kissé morcos", "Sziámi" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Type", "UserName" },
                values: new object[,]
                {
                    { new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), 0, "2069c9ad-3379-4f82-98f6-8abb1a20190c", "Egzotikus állatok szakértője.", null, false, false, null, "Dr. Kiss Tamás", null, null, null, null, false, null, false, 1, null },
                    { new Guid("8b7f7681-8f97-443f-bea3-c875c3fe0be2"), 0, "2ac6a7bd-01a0-42a9-b9bf-68d3efe9b8d4", "A klinika segédje, minden munkában ott van.", null, false, false, null, "Hajdu Eszter", null, null, null, null, false, null, false, 2, null },
                    { new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), 0, "5156e697-3dfe-419e-a2e9-972071b58853", "Szakértő állatorvos.", null, false, false, null, "Dr. Vakarcs Pál", null, null, null, null, false, null, false, 1, null },
                    { new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), 0, "c38afb1a-2933-41da-abcc-fffde02e5edc", "Sebész specialista.", null, false, false, null, "Dr. Szabó Éva", null, null, null, null, false, null, false, 1, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "BirthDate", "Description", "Name", "Residence" },
                values: new object[,]
                {
                    { new Guid("15663cd5-530e-4f4c-b628-36a0b21f71d1"), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A falu híres állatorvosa.", "Kovács János", "Budapest" },
                    { new Guid("4867bcfe-6032-4de7-8115-c078d7a4a21a"), new DateTime(1992, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kutyakozmetikus, minden kutyát széppé varázsol.", "Szabó Katalin", "Debrecen" }
                });

            migrationBuilder.InsertData(
                table: "AnimalPerson",
                columns: new[] { "AnimalsId", "OwnersId" },
                values: new object[,]
                {
                    { new Guid("37ee9f58-a30c-4c9a-9e10-8b5b9dadef91"), new Guid("15663cd5-530e-4f4c-b628-36a0b21f71d1") },
                    { new Guid("a49d8156-ac7e-4607-a0e7-fed4c5584cbf"), new Guid("4867bcfe-6032-4de7-8115-c078d7a4a21a") }
                });

            migrationBuilder.InsertData(
                table: "ConsultationTimes",
                columns: new[] { "Id", "DayOfWeek", "Description", "EmployeeId", "EndTime", "IsAvailable", "Month", "StartTime", "Week", "Year" },
                values: new object[,]
                {
                    { new Guid("04b86a9a-990a-467f-bf52-b282d7dcbe58"), 4, "Csütörtöki rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("0fb7212a-99d3-41af-a323-ecc1273b9ac9"), 4, "Csütörtöki rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("1143f884-6cca-40bd-9711-2f9706e42860"), 2, "Általános rendelési idő kedden.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("293544f4-6c0e-4767-acd1-997ff5c33fe6"), 1, "Általános rendelési idő hétfőn.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("2ca60f97-6601-4b1e-a892-f32d1f109d2e"), 1, "Általános rendelési idő hétfőn.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("345ee915-4811-41e7-9972-d613de162c8e"), 4, "Csütörtöki rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("369a96e8-6eda-486f-84e2-c84427863ae6"), 3, "Szerdai rövid rendelés.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("528b6ee5-7839-44e3-b98f-aedc7e2d6aa3"), 4, "Csütörtöki rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("65c7288f-63e9-47d6-9a53-feb153a690a5"), 1, "Általános rendelési idő hétfőn.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 17, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("67bd0c90-50cb-40a2-98cf-ccf08bd2e341"), 5, "Pénteki rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("91157b6d-e939-4293-95a3-236471b9cd3e"), 5, "Pénteki rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("946ecf2a-1c0e-415c-bcb8-eb124a1079fd"), 4, "Csütörtöki rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("ad9d9f61-74d1-471f-9428-3f2e651cdd1c"), 3, "Szerdai rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("b7d18393-6dc7-4dac-87d1-4b90cfb3ecf2"), 3, "Szerdai rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("c537a72a-aa0e-4ff6-9481-41ca4516aec0"), 3, "Szerdai rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("c8f758c9-2ad8-4701-b44c-c7bf8a0bd074"), 3, "Szerdai rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 14, 0, 0, 0), true, (byte)11, new TimeSpan(0, 8, 0, 0, 0), (byte)46, (short)2024 },
                    { new Guid("ca18137e-8211-42f8-9d40-be5e9e224a6a"), 1, "Hétfői rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)12, new TimeSpan(0, 11, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("cc35bdeb-8115-4759-b4db-8a526e53240b"), 3, "Szerdai rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)50, (short)2024 },
                    { new Guid("d383d2a8-3591-482b-9441-610a62a7910b"), 2, "Általános rendelési idő kedden.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("e3a74f74-02e0-42a0-a55d-38a5596c5cbb"), 2, "Általános rendelési idő kedden.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 16, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)48, (short)2024 },
                    { new Guid("eb4238ee-0a4b-4a96-ad96-77f73162e0a6"), 5, "Pénteki rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)52, (short)2024 },
                    { new Guid("ed3d47a2-3f2b-4dce-9ee2-d5bc4b7e0d44"), 3, "Szerdai rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)51, (short)2024 },
                    { new Guid("ef941b35-d326-4086-aa17-08767fad7169"), 5, "Pénteki rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)11, new TimeSpan(0, 10, 0, 0, 0), (byte)47, (short)2024 },
                    { new Guid("f1246005-2788-4a25-8572-b7feb7a12ce9"), 5, "Pénteki rendelés.", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new TimeSpan(0, 18, 0, 0, 0), true, (byte)12, new TimeSpan(0, 10, 0, 0, 0), (byte)53, (short)2024 },
                    { new Guid("f753ce79-c09e-4f87-97d9-96502650ab96"), 3, "Szerdai rendelés.", new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"), new TimeSpan(0, 15, 0, 0, 0), true, (byte)12, new TimeSpan(0, 8, 0, 0, 0), (byte)49, (short)2024 },
                    { new Guid("ff58baec-27ea-4288-b718-c02470b623df"), 3, "Szerdai rövid rendelés.", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new TimeSpan(0, 12, 0, 0, 0), true, (byte)11, new TimeSpan(0, 9, 0, 0, 0), (byte)47, (short)2024 }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Amount", "AnimalId", "Date", "Description", "DoctorId", "PersonId" },
                values: new object[,]
                {
                    { new Guid("61156665-4e3e-477a-8629-bb5b96499a5e"), 30000m, new Guid("a49d8156-ac7e-4607-a0e7-fed4c5584cbf"), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolhaírtás", new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"), new Guid("4867bcfe-6032-4de7-8115-c078d7a4a21a") },
                    { new Guid("dda73405-2147-490f-832b-20d2f9215e46"), 15000m, new Guid("37ee9f58-a30c-4c9a-9e10-8b5b9dadef91"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutin vizsgálat", new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"), new Guid("15663cd5-530e-4f4c-b628-36a0b21f71d1") }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "Description", "HistoryId", "Length", "Medicine", "TreatmentId", "Type" },
                values: new object[] { new Guid("75a4d509-b71e-4f36-91a5-737947b92f22"), "Alapvizsgálat", null, 30, "Védőoltás", new Guid("dda73405-2147-490f-832b-20d2f9215e46"), 1 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("37ee9f58-a30c-4c9a-9e10-8b5b9dadef91"), new Guid("15663cd5-530e-4f4c-b628-36a0b21f71d1") });

            migrationBuilder.DeleteData(
                table: "AnimalPerson",
                keyColumns: new[] { "AnimalsId", "OwnersId" },
                keyValues: new object[] { new Guid("a49d8156-ac7e-4607-a0e7-fed4c5584cbf"), new Guid("4867bcfe-6032-4de7-8115-c078d7a4a21a") });

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("04b86a9a-990a-467f-bf52-b282d7dcbe58"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("0fb7212a-99d3-41af-a323-ecc1273b9ac9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("1143f884-6cca-40bd-9711-2f9706e42860"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("293544f4-6c0e-4767-acd1-997ff5c33fe6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("2ca60f97-6601-4b1e-a892-f32d1f109d2e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("345ee915-4811-41e7-9972-d613de162c8e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("369a96e8-6eda-486f-84e2-c84427863ae6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("528b6ee5-7839-44e3-b98f-aedc7e2d6aa3"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("65c7288f-63e9-47d6-9a53-feb153a690a5"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("67bd0c90-50cb-40a2-98cf-ccf08bd2e341"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("91157b6d-e939-4293-95a3-236471b9cd3e"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("946ecf2a-1c0e-415c-bcb8-eb124a1079fd"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ad9d9f61-74d1-471f-9428-3f2e651cdd1c"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("b7d18393-6dc7-4dac-87d1-4b90cfb3ecf2"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c537a72a-aa0e-4ff6-9481-41ca4516aec0"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("c8f758c9-2ad8-4701-b44c-c7bf8a0bd074"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ca18137e-8211-42f8-9d40-be5e9e224a6a"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("cc35bdeb-8115-4759-b4db-8a526e53240b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("d383d2a8-3591-482b-9441-610a62a7910b"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("e3a74f74-02e0-42a0-a55d-38a5596c5cbb"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("eb4238ee-0a4b-4a96-ad96-77f73162e0a6"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ed3d47a2-3f2b-4dce-9ee2-d5bc4b7e0d44"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ef941b35-d326-4086-aa17-08767fad7169"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f1246005-2788-4a25-8572-b7feb7a12ce9"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("f753ce79-c09e-4f87-97d9-96502650ab96"));

            migrationBuilder.DeleteData(
                table: "ConsultationTimes",
                keyColumn: "Id",
                keyValue: new Guid("ff58baec-27ea-4288-b718-c02470b623df"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8b7f7681-8f97-443f-bea3-c875c3fe0be2"));

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: new Guid("75a4d509-b71e-4f36-91a5-737947b92f22"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("61156665-4e3e-477a-8629-bb5b96499a5e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a49d8156-ac7e-4607-a0e7-fed4c5584cbf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("05fc838e-09f4-405c-b444-3908f02cbc8f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b5ff8827-c827-484a-ab27-84ce6d67ca9f"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("4867bcfe-6032-4de7-8115-c078d7a4a21a"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("dda73405-2147-490f-832b-20d2f9215e46"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("37ee9f58-a30c-4c9a-9e10-8b5b9dadef91"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9fa5fd43-6c43-435e-a132-246e1b92fc31"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("15663cd5-530e-4f4c-b628-36a0b21f71d1"));

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Employees");

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
    }
}
