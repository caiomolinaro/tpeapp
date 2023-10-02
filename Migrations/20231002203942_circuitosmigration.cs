using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class circuitosmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuitos",
                columns: table => new
                {
                    CircuitoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircuitoNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuitos", x => x.CircuitoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circuitos");
        }
    }
}
