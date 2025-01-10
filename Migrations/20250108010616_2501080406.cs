using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080406 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VolunteerProjectTasks",
                columns: table => new
                {
                    ProjectTaskId = table.Column<int>(type: "integer", nullable: false),
                    VolunteerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerProjectTasks", x => new { x.VolunteerId, x.ProjectTaskId });
                    table.ForeignKey(
                        name: "FK_VolunteerProjectTasks_Tasks_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VolunteerProjectTasks_Users_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerProjectTasks_ProjectTaskId",
                table: "VolunteerProjectTasks",
                column: "ProjectTaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerProjectTasks");
        }
    }
}
