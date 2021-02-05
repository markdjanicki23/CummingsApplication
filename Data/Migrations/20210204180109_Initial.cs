using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CummingsApplication.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    Info = table.Column<string>(nullable: true),
                    DisclaimerAccepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BondTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BondTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defendants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    SocialSecurityNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defendants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indemnitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indemnitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvidingAgencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    AgentName = table.Column<string>(nullable: true),
                    AgencyName = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidingAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestingAgencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BailBondId = table.Column<int>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestingAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BailBondInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidingAgencyId = table.Column<int>(nullable: false),
                    JailId = table.Column<int>(nullable: false),
                    BondTransferId = table.Column<int>(nullable: false),
                    RequestingAgencyId = table.Column<int>(nullable: false),
                    DefendantId = table.Column<int>(nullable: false),
                    IndemnitorId = table.Column<int>(nullable: false),
                    AdditionalInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BailBondInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_AdditionalInfos_AdditionalInfoId",
                        column: x => x.AdditionalInfoId,
                        principalTable: "AdditionalInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_BondTransfers_BondTransferId",
                        column: x => x.BondTransferId,
                        principalTable: "BondTransfers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_Defendants_DefendantId",
                        column: x => x.DefendantId,
                        principalTable: "Defendants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_Indemnitors_IndemnitorId",
                        column: x => x.IndemnitorId,
                        principalTable: "Indemnitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_Jails_JailId",
                        column: x => x.JailId,
                        principalTable: "Jails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_ProvidingAgencies_ProvidingAgencyId",
                        column: x => x.ProvidingAgencyId,
                        principalTable: "ProvidingAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BailBondInfos_RequestingAgencies_RequestingAgencyId",
                        column: x => x.RequestingAgencyId,
                        principalTable: "RequestingAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "ProvidingAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BailBondInfos_RequestingAgencyId",
                table: "BailBondInfos",
                column: "RequestingAgencyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BailBondInfos");

            migrationBuilder.DropTable(
                name: "AdditionalInfos");

            migrationBuilder.DropTable(
                name: "BondTransfers");

            migrationBuilder.DropTable(
                name: "Defendants");

            migrationBuilder.DropTable(
                name: "Indemnitors");

            migrationBuilder.DropTable(
                name: "Jails");

            migrationBuilder.DropTable(
                name: "ProvidingAgencies");

            migrationBuilder.DropTable(
                name: "RequestingAgencies");
        }
    }
}
