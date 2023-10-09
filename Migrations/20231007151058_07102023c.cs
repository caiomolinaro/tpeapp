using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CongregationId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CongregationsCongregationId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CongregationsCongregationId",
                table: "Users",
                column: "CongregationsCongregationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Congregations_CongregationsCongregationId",
                table: "Users",
                column: "CongregationsCongregationId",
                principalTable: "Congregations",
                principalColumn: "CongregationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Congregations_CongregationsCongregationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CongregationsCongregationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CongregationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CongregationsCongregationId",
                table: "Users");
        }
    }
}
