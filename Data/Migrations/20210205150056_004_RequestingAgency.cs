using Microsoft.EntityFrameworkCore.Migrations;

namespace CummingsApplication.Data.Migrations
{
    public partial class _004_RequestingAgency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RequestingAgencies",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amount",
                table: "BondTransfers",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "RequestingAgencies");

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "BondTransfers",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
