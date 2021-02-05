using Microsoft.EntityFrameworkCore.Migrations;

namespace CummingsApplication.Data.Migrations
{
    public partial class _004_Indemnitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ethnicity",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobilePhoneNumber",
                table: "Indemnitors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialSecurityNumber",
                table: "Indemnitors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "Ethnicity",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "MobilePhoneNumber",
                table: "Indemnitors");

            migrationBuilder.DropColumn(
                name: "SocialSecurityNumber",
                table: "Indemnitors");
        }
    }
}
