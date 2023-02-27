using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "vols");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "vols",
                newName: "IX_vols_PlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Pasengers",
                type: "nchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "name",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_vols",
                table: "vols",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_vols_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "vols",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vols_Planes_PlaneId",
                table: "vols",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_vols_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_vols_Planes_PlaneId",
                table: "vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vols",
                table: "vols");

            migrationBuilder.RenameTable(
                name: "vols",
                newName: "Flights");

            migrationBuilder.RenameIndex(
                name: "IX_vols_PlaneId",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Pasengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(80)",
                oldMaxLength: 80,
                oldDefaultValue: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
