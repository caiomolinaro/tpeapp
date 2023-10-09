using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchedulesId1",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeekDayId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeekDaysModelWeekDayId",
                table: "Schedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_SchedulesId1",
                table: "Schedules",
                column: "SchedulesId1");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_WeekDaysModelWeekDayId",
                table: "Schedules",
                column: "WeekDaysModelWeekDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Schedules_SchedulesId1",
                table: "Schedules",
                column: "SchedulesId1",
                principalTable: "Schedules",
                principalColumn: "SchedulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_WeekDays_WeekDaysModelWeekDayId",
                table: "Schedules",
                column: "WeekDaysModelWeekDayId",
                principalTable: "WeekDays",
                principalColumn: "WeekDayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Schedules_SchedulesId1",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_WeekDays_WeekDaysModelWeekDayId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_SchedulesId1",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_WeekDaysModelWeekDayId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "SchedulesId1",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WeekDayId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "WeekDaysModelWeekDayId",
                table: "Schedules");
        }
    }
}
