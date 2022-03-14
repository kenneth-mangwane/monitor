using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class bookings1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bookings_LeaseId",
                schema: "obs",
                table: "Bookings",
                column: "LeaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings",
                column: "LeaseId",
                principalSchema: "obs",
                principalTable: "Leases",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Leases_LeaseId",
                schema: "obs",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_LeaseId",
                schema: "obs",
                table: "Bookings");
        }
    }
}
