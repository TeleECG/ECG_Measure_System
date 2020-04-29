using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalDatabase.Migrations
{
    public partial class URLtoCPR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "CPRNumber",
                table: "Patients",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPRNumber",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Patients",
                type: "TEXT",
                nullable: true);
        }
    }
}
