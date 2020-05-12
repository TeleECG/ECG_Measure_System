using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Layer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientMeasurements",
                columns: table => new
                {
                    PatientMeasurementId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPRNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMeasurements", x => x.PatientMeasurementId);
                });

            migrationBuilder.CreateTable(
                name: "ECGMeasurements",
                columns: table => new
                {
                    ECGMeasurementId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientMeasurementId = table.Column<int>(nullable: false),
                    MeasurementNumber = table.Column<int>(nullable: false),
                    Pulse = table.Column<int>(nullable: false),
                    HRV = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECGMeasurements", x => x.ECGMeasurementId);
                    table.ForeignKey(
                        name: "FK_ECGMeasurements_PatientMeasurements_PatientMeasurementId",
                        column: x => x.PatientMeasurementId,
                        principalTable: "PatientMeasurements",
                        principalColumn: "PatientMeasurementId",
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
                    ECGLeadValues = table.Column<byte[]>(nullable: true)
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
                name: "IX_ECGMeasurements_PatientMeasurementId",
                table: "ECGMeasurements",
                column: "PatientMeasurementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECGLeads");

            migrationBuilder.DropTable(
                name: "ECGMeasurements");

            migrationBuilder.DropTable(
                name: "PatientMeasurements");
        }
    }
}
