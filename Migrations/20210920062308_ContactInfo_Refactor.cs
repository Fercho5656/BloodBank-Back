using Microsoft.EntityFrameworkCore.Migrations;

namespace bloodbank.Migrations
{
    public partial class ContactInfo_Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactInfoId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactInfoId",
                table: "Hospitals",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactInfoId",
                table: "Donor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactInfoId",
                table: "BloodBanks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ContactInfoId",
                table: "Patients",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_ContactInfoId",
                table: "Hospitals",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_ContactInfoId",
                table: "Donor",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodBanks_ContactInfoId",
                table: "BloodBanks",
                column: "ContactInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodBanks_ContactInfo_ContactInfoId",
                table: "BloodBanks",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_ContactInfo_ContactInfoId",
                table: "Donor",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_ContactInfo_ContactInfoId",
                table: "Hospitals",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_ContactInfo_ContactInfoId",
                table: "Patients",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodBanks_ContactInfo_ContactInfoId",
                table: "BloodBanks");

            migrationBuilder.DropForeignKey(
                name: "FK_Donor_ContactInfo_ContactInfoId",
                table: "Donor");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_ContactInfo_ContactInfoId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_ContactInfo_ContactInfoId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropIndex(
                name: "IX_Patients_ContactInfoId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_ContactInfoId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Donor_ContactInfoId",
                table: "Donor");

            migrationBuilder.DropIndex(
                name: "IX_BloodBanks_ContactInfoId",
                table: "BloodBanks");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "BloodBanks");
        }
    }
}
