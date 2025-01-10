using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080637 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DonationItemTypes",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DonationItemTypes");
        }
    }
}
