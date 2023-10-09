using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _09102023g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersSchedules_Users_UsersId",
                table: "UsersSchedules");

            migrationBuilder.DropIndex(
                name: "IX_UsersSchedules_UsersId",
                table: "UsersSchedules");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "UsersSchedules",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "UsersSchedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersSchedules_UsersUserId",
                table: "UsersSchedules",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSchedules_Users_UsersUserId",
                table: "UsersSchedules",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersSchedules_Users_UsersUserId",
                table: "UsersSchedules");

            migrationBuilder.DropIndex(
                name: "IX_UsersSchedules_UsersUserId",
                table: "UsersSchedules");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "UsersSchedules");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UsersSchedules",
                newName: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSchedules_UsersId",
                table: "UsersSchedules",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersSchedules_Users_UsersId",
                table: "UsersSchedules",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
