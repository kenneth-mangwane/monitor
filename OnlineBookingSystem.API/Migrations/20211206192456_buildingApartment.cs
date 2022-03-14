using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class buildingApartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Apartment",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apartment",
                schema: "obs",
                table: "Buildings");
        }
    }
}
