using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080303 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VolunteerId = table.Column<int>(type: "integer", nullable: false),
                    ProjectTaskId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskApplications_Projects_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskApplications_Users_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskApplications_ProjectTaskId",
                table: "TaskApplications",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskApplications_VolunteerId",
                table: "TaskApplications",
                column: "VolunteerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskApplications");
        }
    }
}
