using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fluentAPI5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vols_MyPlanes_PlaneId",
                table: "vols");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "vols",
                newName: "PlaneFK");

            migrationBuilder.RenameIndex(
                name: "IX_vols_PlaneId",
                table: "vols",
                newName: "IX_vols_PlaneFK");

            migrationBuilder.AddForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols",
                column: "PlaneFK",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vols_MyPlanes_PlaneFK",
                table: "vols");

            migrationBuilder.RenameColumn(
                name: "PlaneFK",
                table: "vols",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_vols_PlaneFK",
                table: "vols",
                newName: "IX_vols_PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_vols_MyPlanes_PlaneId",
                table: "vols",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
