using Microsoft.EntityFrameworkCore.Migrations;

namespace CummingsApplication.Data.Migrations
{
    public partial class _006_HomeController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_AdditionalInfos_AdditionalInfoId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_BondTransfers_BondTransferId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Defendants_DefendantId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Indemnitors_IndemnitorId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Jails_JailId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_ProvidingAgencies_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_RequestingAgencies_RequestingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_AdditionalInfoId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_BondTransferId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_DefendantId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_IndemnitorId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_JailId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_RequestingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.AlterColumn<int>(
                name: "RequestingAgencyId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProvidingAgencyId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "JailId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IndemnitorId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DefendantId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BondTransferId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalInfoId",
                table: "BailBondInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_AdditionalInfoId",
                table: "BailBondInfos",
                column: "AdditionalInfoId",
                unique: true,
                filter: "[AdditionalInfoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_BondTransferId",
                table: "BailBondInfos",
                column: "BondTransferId",
                unique: true,
                filter: "[BondTransferId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_DefendantId",
                table: "BailBondInfos",
                column: "DefendantId",
                unique: true,
                filter: "[DefendantId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_IndemnitorId",
                table: "BailBondInfos",
                column: "IndemnitorId",
                unique: true,
                filter: "[IndemnitorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_JailId",
                table: "BailBondInfos",
                column: "JailId",
                unique: true,
                filter: "[JailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId",
                unique: true,
                filter: "[ProvidingAgencyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_RequestingAgencyId",
                table: "BailBondInfos",
                column: "RequestingAgencyId",
                unique: true,
                filter: "[RequestingAgencyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_AdditionalInfos_AdditionalInfoId",
                table: "BailBondInfos",
                column: "AdditionalInfoId",
                principalTable: "AdditionalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_BondTransfers_BondTransferId",
                table: "BailBondInfos",
                column: "BondTransferId",
                principalTable: "BondTransfers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Defendants_DefendantId",
                table: "BailBondInfos",
                column: "DefendantId",
                principalTable: "Defendants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Indemnitors_IndemnitorId",
                table: "BailBondInfos",
                column: "IndemnitorId",
                principalTable: "Indemnitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Jails_JailId",
                table: "BailBondInfos",
                column: "JailId",
                principalTable: "Jails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_ProvidingAgencies_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId",
                principalTable: "ProvidingAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_RequestingAgencies_RequestingAgencyId",
                table: "BailBondInfos",
                column: "RequestingAgencyId",
                principalTable: "RequestingAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_AdditionalInfos_AdditionalInfoId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_BondTransfers_BondTransferId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Defendants_DefendantId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Indemnitors_IndemnitorId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_Jails_JailId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_ProvidingAgencies_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_BailBondInfos_RequestingAgencies_RequestingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_AdditionalInfoId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_BondTransferId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_DefendantId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_IndemnitorId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_JailId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.DropIndex(
                name: "IX_BailBondInfos_RequestingAgencyId",
                table: "BailBondInfos");

            migrationBuilder.AlterColumn<int>(
                name: "RequestingAgencyId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProvidingAgencyId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JailId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndemnitorId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DefendantId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BondTransferId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalInfoId",
                table: "BailBondInfos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_AdditionalInfoId",
                table: "BailBondInfos",
                column: "AdditionalInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_BondTransferId",
                table: "BailBondInfos",
                column: "BondTransferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_DefendantId",
                table: "BailBondInfos",
                column: "DefendantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_IndemnitorId",
                table: "BailBondInfos",
                column: "IndemnitorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_JailId",
                table: "BailBondInfos",
                column: "JailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_RequestingAgencyId",
                table: "BailBondInfos",
                column: "RequestingAgencyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_AdditionalInfos_AdditionalInfoId",
                table: "BailBondInfos",
                column: "AdditionalInfoId",
                principalTable: "AdditionalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_BondTransfers_BondTransferId",
                table: "BailBondInfos",
                column: "BondTransferId",
                principalTable: "BondTransfers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Defendants_DefendantId",
                table: "BailBondInfos",
                column: "DefendantId",
                principalTable: "Defendants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Indemnitors_IndemnitorId",
                table: "BailBondInfos",
                column: "IndemnitorId",
                principalTable: "Indemnitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_Jails_JailId",
                table: "BailBondInfos",
                column: "JailId",
                principalTable: "Jails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_ProvidingAgencies_ProvidingAgencyId",
                table: "BailBondInfos",
                column: "ProvidingAgencyId",
                principalTable: "ProvidingAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BailBondInfos_RequestingAgencies_RequestingAgencyId",
                table: "BailBondInfos",
                column: "RequestingAgencyId",
                principalTable: "RequestingAgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
