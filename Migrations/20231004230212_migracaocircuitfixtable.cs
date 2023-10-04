using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class migracaocircuitfixtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Congregations");

            migrationBuilder.DropTable(
                name: "Circuits");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    CircuitName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.CircuitName);
                });

            migrationBuilder.CreateTable(
                name: "Congregations",
                columns: table => new
                {
                    CongregationName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CircuitsCircuitName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CircuitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congregations", x => x.CongregationName);
                    table.ForeignKey(
                        name: "FK_Congregations_Circuits_CircuitsCircuitName",
                        column: x => x.CircuitsCircuitName,
                        principalTable: "Circuits",
                        principalColumn: "CircuitName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Congregations_CircuitsCircuitName",
                table: "Congregations",
                column: "CircuitsCircuitName");
        }
    }
}
