using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrPetClinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConsultationTimeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Month",
                table: "ConsultationTimes",
                type: "tinyint",
                maxLength: 12,
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Week",
                table: "ConsultationTimes",
                type: "tinyint",
                maxLength: 53,
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<short>(
                name: "Year",
                table: "ConsultationTimes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "ConsultationTimes");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "ConsultationTimes");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "ConsultationTimes");
        }
    }
}
