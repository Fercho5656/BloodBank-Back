using Microsoft.EntityFrameworkCore.Migrations;

namespace bloodbank.Migrations
{
    public partial class BloodGroup_BloodBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DropTable(
                name: "BloodBankBloodGroup"); */

            migrationBuilder.CreateTable(
                name: "BloodGroups_BloodBanks",
                columns: table => new
                {
                    BloodGroupId = table.Column<int>(type: "int", nullable: false),
                    BloodBankId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroups_BloodBanks", x => new { x.BloodGroupId, x.BloodBankId });
                    table.ForeignKey(
                        name: "FK_BloodGroups_BloodBanks_BloodBanks_BloodBankId",
                        column: x => x.BloodBankId,
                        principalTable: "BloodBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodGroups_BloodBanks_BloodGroups_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodGroups_BloodBanks_BloodBankId",
                table: "BloodGroups_BloodBanks",
                column: "BloodBankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodGroups_BloodBanks");

            migrationBuilder.CreateTable(
                name: "BloodBankBloodGroup",
                columns: table => new
                {
                    BloodBanksId = table.Column<int>(type: "int", nullable: false),
                    BloodGroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBankBloodGroup", x => new { x.BloodBanksId, x.BloodGroupsId });
                    table.ForeignKey(
                        name: "FK_BloodBankBloodGroup_BloodBanks_BloodBanksId",
                        column: x => x.BloodBanksId,
                        principalTable: "BloodBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodBankBloodGroup_BloodGroups_BloodGroupsId",
                        column: x => x.BloodGroupsId,
                        principalTable: "BloodGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodBankBloodGroup_BloodGroupsId",
                table: "BloodBankBloodGroup",
                column: "BloodGroupsId");
        }
    }
}
