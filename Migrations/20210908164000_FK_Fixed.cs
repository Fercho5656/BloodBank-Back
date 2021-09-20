using Microsoft.EntityFrameworkCore.Migrations;

namespace bloodbank.Migrations
{
    public partial class FK_Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "FamilyGroupId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DiseaseId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BloodBankId",
                table: "BloodGroups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DiseaseId",
                table: "Patients",
                column: "DiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_FamilyGroupId",
                table: "Patients",
                column: "FamilyGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodGroups_BloodBankId",
                table: "BloodGroups",
                column: "BloodBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodGroups_BloodBanks_BloodBankId",
                table: "BloodGroups",
                column: "BloodBankId",
                principalTable: "BloodBanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Diseases_DiseaseId",
                table: "Patients",
                column: "DiseaseId",
                principalTable: "Diseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_FamilyGroups_FamilyGroupId",
                table: "Patients",
                column: "FamilyGroupId",
                principalTable: "FamilyGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodGroups_BloodBanks_BloodBankId",
                table: "BloodGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Diseases_DiseaseId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_FamilyGroups_FamilyGroupId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_FamilyGroupId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_BloodGroups_BloodBankId",
                table: "BloodGroups");

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

            migrationBuilder.AlterColumn<int>(
                name: "FamilyGroupId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiseaseId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BloodBankId",
                table: "BloodGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
