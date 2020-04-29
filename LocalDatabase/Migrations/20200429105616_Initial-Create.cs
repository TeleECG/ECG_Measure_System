using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDatabase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Pulse = table.Column<int>(nullable: false),
                    HRV = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "ECGMeasurements",
                columns: table => new
                {
                    ECGMeasurementId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECGMeasurements", x => x.ECGMeasurementId);
                    table.ForeignKey(
                        name: "FK_ECGMeasurements_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ECGLeads",
                columns: table => new
                {
                    ECGLeadId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ECGMeasurementId = table.Column<int>(nullable: false),
                    LeadNumber = table.Column<int>(nullable: false),
                    ECGLeadValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECGLeads", x => x.ECGLeadId);
                    table.ForeignKey(
                        name: "FK_ECGLeads_ECGMeasurements_ECGMeasurementId",
                        column: x => x.ECGMeasurementId,
                        principalTable: "ECGMeasurements",
                        principalColumn: "ECGMeasurementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECGLeads_ECGMeasurementId",
                table: "ECGLeads",
                column: "ECGMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ECGMeasurements_PatientId",
                table: "ECGMeasurements",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECGLeads");

            migrationBuilder.DropTable(
                name: "ECGMeasurements");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
