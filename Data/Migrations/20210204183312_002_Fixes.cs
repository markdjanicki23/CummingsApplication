using Microsoft.EntityFrameworkCore.Migrations;

namespace CummingsApplication.Data.Migrations
{
    public partial class _002_Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId");
        }
    }
}
