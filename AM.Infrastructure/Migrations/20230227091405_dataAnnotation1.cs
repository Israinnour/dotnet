using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dataAnnotation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pasengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "Pasengers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Pasengers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInformation",
                table: "Pasengers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Pasengers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Pasengers",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pasengers");

            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "Pasengers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Pasengers");

            migrationBuilder.DropColumn(
                name: "HealthInformation",
                table: "Pasengers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Pasengers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Pasengers");
        }
    }
}
