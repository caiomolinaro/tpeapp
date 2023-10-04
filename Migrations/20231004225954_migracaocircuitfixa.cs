using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class migracaocircuitfixa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations");

            migrationBuilder.DropIndex(
                name: "IX_Congregations_CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits");

            migrationBuilder.DropColumn(
                name: "CongregationId",
                table: "Congregations");

            migrationBuilder.DropColumn(
                name: "CircuitsCircuitId",
                table: "Congregations");

            migrationBuilder.DropColumn(
                name: "CircuitId",
                table: "Circuits");

            migrationBuilder.AlterColumn<string>(
                name: "CongregationName",
                table: "Congregations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CircuitsCircuitName",
                table: "Congregations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CircuitName",
                table: "Circuits",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations",
                column: "CongregationName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits",
                column: "CircuitName");

            migrationBuilder.CreateIndex(
                name: "IX_Congregations_CircuitsCircuitName",
                table: "Congregations",
                column: "CircuitsCircuitName");

            migrationBuilder.AddForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitName",
                table: "Congregations",
                column: "CircuitsCircuitName",
                principalTable: "Circuits",
                principalColumn: "CircuitName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Congregations_Circuits_CircuitsCircuitName",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations");

            migrationBuilder.DropIndex(
                name: "IX_Congregations_CircuitsCircuitName",
                table: "Congregations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits");

            migrationBuilder.DropColumn(
                name: "CircuitsCircuitName",
                table: "Congregations");

            migrationBuilder.AlterColumn<string>(
                name: "CongregationName",
                table: "Congregations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CongregationId",
                table: "Congregations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CircuitsCircuitId",
                table: "Congregations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CircuitName",
                table: "Circuits",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CircuitId",
                table: "Circuits",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Congregations",
                table: "Congregations",
                column: "CongregationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Circuits",
                table: "Circuits",
                column: "CircuitId");

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
