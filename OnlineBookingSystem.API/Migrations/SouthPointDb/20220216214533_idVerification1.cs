using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations.SouthPointDb
{
    public partial class idVerification1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IDRecordId",
                table: "IDVerifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPassport",
                table: "IDVerifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "IDVerifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IDRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dateOfQuery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    smartCardIssued = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idIssueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idSequenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idNumberBlocked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deceasedStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfDeath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateOfMarriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    onHANIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    onNPR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hanisReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    responseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    responseError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IDRecords", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IDVerifications_IDRecordId",
                table: "IDVerifications",
                column: "IDRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_IDVerifications_UserId",
                table: "IDVerifications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IDVerifications_AspNetUsers_UserId",
                table: "IDVerifications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IDVerifications_IDRecords_IDRecordId",
                table: "IDVerifications",
                column: "IDRecordId",
                principalTable: "IDRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IDVerifications_AspNetUsers_UserId",
                table: "IDVerifications");

            migrationBuilder.DropForeignKey(
                name: "FK_IDVerifications_IDRecords_IDRecordId",
                table: "IDVerifications");

            migrationBuilder.DropTable(
                name: "IDRecords");

            migrationBuilder.DropIndex(
                name: "IX_IDVerifications_IDRecordId",
                table: "IDVerifications");

            migrationBuilder.DropIndex(
                name: "IX_IDVerifications_UserId",
                table: "IDVerifications");

            migrationBuilder.DropColumn(
                name: "IDRecordId",
                table: "IDVerifications");

            migrationBuilder.DropColumn(
                name: "IsPassport",
                table: "IDVerifications");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "IDVerifications");
        }
    }
}
