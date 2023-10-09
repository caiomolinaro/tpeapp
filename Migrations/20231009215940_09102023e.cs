using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _09102023e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchedulesId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SchedulesId",
                table: "Users",
                column: "SchedulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Schedules_SchedulesId",
                table: "Users",
                column: "SchedulesId",
                principalTable: "Schedules",
                principalColumn: "SchedulesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Schedules_SchedulesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SchedulesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SchedulesId",
                table: "Users");
        }
    }
}
