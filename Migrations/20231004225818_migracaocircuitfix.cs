using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class migracaocircuitfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CongregationsName_CircuitsName_CircuitsCircuitId",
                table: "CongregationsName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CongregationsName",
                table: "CongregationsName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CircuitsName",
                table: "CircuitsName");

            migrationBuilder.RenameTable(
                name: "CongregationsName",
                newName: "Congregations");

            migrationBuilder.RenameTable(
                name: "CircuitsName",
                newName: "Circuits");

            migrationBuilder.RenameIndex(
                name: "IX_CongregationsName_CircuitsCircuitId",
                table: "Congregations",
                newName: "IX_Congregations_CircuitsCircuitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations",
                column: "CongregationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits",
                column: "CircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations",
                column: "CircuitsCircuitId",
                principalTable: "Circuits",
                principalColumn: "CircuitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits");

            migrationBuilder.RenameTable(
                name: "Congregations",
                newName: "CongregationsName");

            migrationBuilder.RenameTable(
                name: "Circuits",
                newName: "CircuitsName");

            migrationBuilder.RenameIndex(
                name: "IX_Congregations_CircuitsCircuitId",
                table: "CongregationsName",
                newName: "IX_CongregationsName_CircuitsCircuitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CongregationsName",
                table: "CongregationsName",
                column: "CongregationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CircuitsName",
                table: "CircuitsName",
                column: "CircuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_CongregationsName_CircuitsName_CircuitsCircuitId",
                table: "CongregationsName",
                column: "CircuitsCircuitId",
                principalTable: "CircuitsName",
                principalColumn: "CircuitId");
        }
    }
}
