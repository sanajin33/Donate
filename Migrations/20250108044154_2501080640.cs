using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080640 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationItems_DonationItemTypes_ItemtypeId",
                table: "DonationItems");

            migrationBuilder.RenameColumn(
                name: "ItemtypeId",
                table: "DonationItems",
                newName: "ItemTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DonationItems_ItemtypeId",
                table: "DonationItems",
                newName: "IX_DonationItems_ItemTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationItems_DonationItemTypes_ItemTypeId",
                table: "DonationItems",
                column: "ItemTypeId",
                principalTable: "DonationItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationItems_DonationItemTypes_ItemTypeId",
                table: "DonationItems");

            migrationBuilder.RenameColumn(
                name: "ItemTypeId",
                table: "DonationItems",
                newName: "ItemtypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DonationItems_ItemTypeId",
                table: "DonationItems",
                newName: "IX_DonationItems_ItemtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationItems_DonationItemTypes_ItemtypeId",
                table: "DonationItems",
                column: "ItemtypeId",
                principalTable: "DonationItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
