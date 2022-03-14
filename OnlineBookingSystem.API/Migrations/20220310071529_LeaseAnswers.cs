using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class LeaseAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaseMarketingAnswers",
                schema: "obs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaseID = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaseMarketingAnswers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeaseMarketingAnswers_Leases_LeaseID",
                        column: x => x.LeaseID,
                        principalSchema: "obs",
                        principalTable: "Leases",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaseMarketingAnswers_LeaseID",
                schema: "obs",
                table: "LeaseMarketingAnswers",
                column: "LeaseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaseMarketingAnswers",
                schema: "obs");
        }
    }
}
