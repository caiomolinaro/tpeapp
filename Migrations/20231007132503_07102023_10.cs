using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Schedules_SchedulesId1",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_WeekDays_WeekDaysModelWeekDayId",
                table: "Schedules");

            migrationBuilder.DropTable(
                name: "WeekDays");

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

            migrationBuilder.AddColumn<bool>(
                name: "Friday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Monday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Saturday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sunday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Thursday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tuesday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wednesday",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Monday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Saturday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Sunday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Thursday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Tuesday",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Wednesday",
                table: "Schedules");

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

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    WeekDayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    Sunday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.WeekDayId);
                });

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
    }
}
