using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501071931 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", "Admin", "ADMIN" },
                    { 2, "0812dbe6-4c5b-4c05-8271-4cfdefa6df9d", "Donor", "DONOR" },
                    { 3, "4aba19c4-62f5-4bc1-a002-633e78671ced", "Volunteer", "VOLUNTEER" },
                    { 4, "040cbb41-c9fd-4cda-8e86-ceb533a31214", "Organization", "ORGANIZATION" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", "admin@donate.com", true, false, null, "ADMIN@DONATE.COM", "ADMIN@DONATE.COM", "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==", "987-6543", false, "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP", false, "admin@donate.com" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
