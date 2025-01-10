using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501072104 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2, 0, "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", "organization@donate.com", true, false, null, "ORGANIZATION@DONATE.COM", "ORGANIZATION@DONATE.COM", "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==", "654-3210", false, "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP", false, "organization@donate.com" },
                    { 3, 0, "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", "donor@donate.com", true, false, null, "DONOR@DONATE.COM", "DONOR@DONATE.COM", "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==", "954-7426", false, "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP", false, "donor@donate.com" },
                    { 4, 0, "43e6c8b7-c1b1-472a-8571-c38842d2c2a6", "volunteer@donate.com", true, false, null, "VOLUNTEER@DONATE.COM", "VOLUNTEER@DONATE.COM", "AQAAAAIAAYagAAAAEAGZNJNvdBuKNtaM2dyM8mzA4zDqCpas3ZW9LIrIH6eOSyZoCsie604/X/MCCTtDVA==", "6354-8521", false, "TZ45JZFMMFQ463YMULFD5DW6LFNE4ISP", false, "volunteer@donate.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
