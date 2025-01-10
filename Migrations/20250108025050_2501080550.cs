using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080550 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskApplications_Projects_ProjectTaskId",
                table: "TaskApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskApplications_Tasks_ProjectTaskId",
                table: "TaskApplications",
                column: "ProjectTaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskApplications_Tasks_ProjectTaskId",
                table: "TaskApplications");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskApplications_Projects_ProjectTaskId",
                table: "TaskApplications",
                column: "ProjectTaskId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
