using Microsoft.EntityFrameworkCore.Migrations;

namespace bloodbank.Migrations
{
    public partial class Role_TableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodTests_Donor_DonorId",
                table: "BloodTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Donor_BloodGroups_BloodGroupId",
                table: "Donor");

            migrationBuilder.DropForeignKey(
                name: "FK_Donor_ContactInfo_ContactInfoId",
                table: "Donor");

            migrationBuilder.DropForeignKey(
                name: "FK_Donor_FamilyGroups_FamilyGroupId",
                table: "Donor");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingBlood_Donor_DonorId",
                table: "IncomingBlood");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donor",
                table: "Donor");

            migrationBuilder.RenameTable(
                name: "Donor",
                newName: "Donors");

            migrationBuilder.RenameIndex(
                name: "IX_Donor_FamilyGroupId",
                table: "Donors",
                newName: "IX_Donors_FamilyGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Donor_ContactInfoId",
                table: "Donors",
                newName: "IX_Donors_ContactInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Donor_BloodGroupId",
                table: "Donors",
                newName: "IX_Donors_BloodGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donors",
                table: "Donors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BloodTests_Donors_DonorId",
                table: "BloodTests",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_BloodGroups_BloodGroupId",
                table: "Donors",
                column: "BloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_ContactInfo_ContactInfoId",
                table: "Donors",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_FamilyGroups_FamilyGroupId",
                table: "Donors",
                column: "FamilyGroupId",
                principalTable: "FamilyGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingBlood_Donors_DonorId",
                table: "IncomingBlood",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BloodTests_Donors_DonorId",
                table: "BloodTests");

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_BloodGroups_BloodGroupId",
                table: "Donors");

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_ContactInfo_ContactInfoId",
                table: "Donors");

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_FamilyGroups_FamilyGroupId",
                table: "Donors");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomingBlood_Donors_DonorId",
                table: "IncomingBlood");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donors",
                table: "Donors");

            migrationBuilder.RenameTable(
                name: "Donors",
                newName: "Donor");

            migrationBuilder.RenameIndex(
                name: "IX_Donors_FamilyGroupId",
                table: "Donor",
                newName: "IX_Donor_FamilyGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Donors_ContactInfoId",
                table: "Donor",
                newName: "IX_Donor_ContactInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Donors_BloodGroupId",
                table: "Donor",
                newName: "IX_Donor_BloodGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donor",
                table: "Donor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BloodTests_Donor_DonorId",
                table: "BloodTests",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_BloodGroups_BloodGroupId",
                table: "Donor",
                column: "BloodGroupId",
                principalTable: "BloodGroups",
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
                name: "FK_Donor_FamilyGroups_FamilyGroupId",
                table: "Donor",
                column: "FamilyGroupId",
                principalTable: "FamilyGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IncomingBlood_Donor_DonorId",
                table: "IncomingBlood",
                column: "DonorId",
                principalTable: "Donor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
