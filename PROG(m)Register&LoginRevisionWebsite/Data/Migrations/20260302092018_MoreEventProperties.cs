using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG_m_Register_LoginRevisionWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoreEventProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttendeeEmail",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AttendeeName",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EventAddress",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PaymentAmount",
                table: "Event",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttendeeEmail",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "AttendeeName",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EventAddress",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Event");
        }
    }
}
