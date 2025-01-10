using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080636 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "DonationItemTypes",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "DonationItemTypes");
        }
    }
}
