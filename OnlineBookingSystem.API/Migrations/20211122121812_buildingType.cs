using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class buildingType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cluster",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Domitory",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasElectricity",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasParking",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPrepaidWater",
                schema: "obs",
                table: "Buildings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cluster",
                schema: "obs",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Domitory",
                schema: "obs",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "HasElectricity",
                schema: "obs",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "HasParking",
                schema: "obs",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "HasPrepaidWater",
                schema: "obs",
                table: "Buildings");
        }
    }
}
