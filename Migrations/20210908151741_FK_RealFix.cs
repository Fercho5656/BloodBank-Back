using Microsoft.EntityFrameworkCore.Migrations;

namespace bloodbank.Migrations
{
    public partial class FK_RealFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FamilyGroups",
                newName: "FamilyGroupId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Diseases",
                newName: "DiseaseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodGroups",
                newName: "BloodGroupId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BloodBanks",
                newName: "BloodBankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FamilyGroupId",
                table: "FamilyGroups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DiseaseId",
                table: "Diseases",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BloodGroupId",
                table: "BloodGroups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BloodBankId",
                table: "BloodBanks",
                newName: "Id");
        }
    }
}
