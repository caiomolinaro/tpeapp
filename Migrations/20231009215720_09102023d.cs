using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _09102023d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchedulesId",
                table: "Points",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Points_SchedulesId",
                table: "Points",
                column: "SchedulesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Schedules_SchedulesId",
                table: "Points",
                column: "SchedulesId",
                principalTable: "Schedules",
                principalColumn: "SchedulesId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Points_Schedules_SchedulesId",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_Points_SchedulesId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "SchedulesId",
                table: "Points");
        }
    }
}
