using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _09102023c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Congregations_Circuits_CircuitsModelCircuitId",
                table: "Congregations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Congregations_CongregationsModelCongregationId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CongregationsModelCongregationId",
                table: "Users",
                newName: "CongregationsCongregationId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CongregationsModelCongregationId",
                table: "Users",
                newName: "IX_Users_CongregationsCongregationId");

            migrationBuilder.RenameColumn(
                name: "CircuitsModelCircuitId",
                table: "Congregations",
                newName: "CircuitsCircuitId");

            migrationBuilder.RenameIndex(
                name: "IX_Congregations_CircuitsModelCircuitId",
                table: "Congregations",
                newName: "IX_Congregations_CircuitsCircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations",
                column: "CircuitsCircuitId",
                principalTable: "Circuits",
                principalColumn: "CircuitId");

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
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Congregations_CongregationsCongregationId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CongregationsCongregationId",
                table: "Users",
                newName: "CongregationsModelCongregationId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CongregationsCongregationId",
                table: "Users",
                newName: "IX_Users_CongregationsModelCongregationId");

            migrationBuilder.RenameColumn(
                name: "CircuitsCircuitId",
                table: "Congregations",
                newName: "CircuitsModelCircuitId");

            migrationBuilder.RenameIndex(
                name: "IX_Congregations_CircuitsCircuitId",
                table: "Congregations",
                newName: "IX_Congregations_CircuitsModelCircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Congregations_Circuits_CircuitsModelCircuitId",
                table: "Congregations",
                column: "CircuitsModelCircuitId",
                principalTable: "Circuits",
                principalColumn: "CircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Congregations_CongregationsModelCongregationId",
                table: "Users",
                column: "CongregationsModelCongregationId",
                principalTable: "Congregations",
                principalColumn: "CongregationId");
        }
    }
}
