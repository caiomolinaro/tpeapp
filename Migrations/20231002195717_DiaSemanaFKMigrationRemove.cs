using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class DiaSemanaFKMigrationRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "DiasSemana");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "DiasSemana",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
