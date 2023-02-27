using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentAPI7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Pasengers_PassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_vols_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "myPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "myPassenger",
                newName: "IX_myPassenger_PassengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "vols",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_myPassenger",
                table: "myPassenger",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_myPassenger_Pasengers_PassengersPassportNumber",
                table: "myPassenger",
                column: "PassengersPassportNumber",
                principalTable: "Pasengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_myPassenger_vols_FlightsFlightId",
                table: "myPassenger",
                column: "FlightsFlightId",
                principalTable: "vols",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols",
                column: "PlaneFK",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_myPassenger_Pasengers_PassengersPassportNumber",
                table: "myPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_myPassenger_vols_FlightsFlightId",
                table: "myPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_myPassenger",
                table: "myPassenger");

            migrationBuilder.RenameTable(
                name: "myPassenger",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_myPassenger_PassengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "vols",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Pasengers_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber",
                principalTable: "Pasengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_vols_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "vols",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols",
                column: "PlaneFK",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
