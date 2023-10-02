using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class pontosupdatemigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pontos",
                columns: table => new
                {
                    PontosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pontosNome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontos", x => x.PontosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pontos");
        }
    }
}
