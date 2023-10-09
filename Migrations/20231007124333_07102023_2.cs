using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropIndex(
                name: "IX_Congregations_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropColumn(
                name: "CircuitId",
                table: "Congregations");

            migrationBuilder.DropColumn(
                name: "CircuitsCircuitId",
                table: "Congregations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CircuitId",
                table: "Congregations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CircuitsCircuitId",
                table: "Congregations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Congregations_CircuitsCircuitId",
                table: "Congregations",
                column: "CircuitsCircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations",
                column: "CircuitsCircuitId",
                principalTable: "Circuits",
                principalColumn: "CircuitId");
        }
    }
}
