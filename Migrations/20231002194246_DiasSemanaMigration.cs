using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class DiasSemanaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiasSemana",
                columns: table => new
                {
                    SegundaFeira = table.Column<bool>(type: "bit", nullable: false),
                    TercaFeira = table.Column<bool>(type: "bit", nullable: false),
                    QuartaFeira = table.Column<bool>(type: "bit", nullable: false),
                    QuintaFeira = table.Column<bool>(type: "bit", nullable: false),
                    SextaFeira = table.Column<bool>(type: "bit", nullable: false),
                    Sabado = table.Column<bool>(type: "bit", nullable: false),
                    Domingo = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiasSemana");
        }
    }
}
