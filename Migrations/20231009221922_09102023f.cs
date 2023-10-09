using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _09102023f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "SchedulesNamePrincipal",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsersSchedules",
                columns: table => new
                {
                    SchedulesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    SchedulesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    Sunday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSchedules", x => x.SchedulesId);
                    table.ForeignKey(
                        name: "FK_UsersSchedules_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersSchedules_UsersId",
                table: "UsersSchedules",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersSchedules");

            migrationBuilder.DropColumn(
                name: "SchedulesNamePrincipal",
                table: "Schedules");

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
    }
}
