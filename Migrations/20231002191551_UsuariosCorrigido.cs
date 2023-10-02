using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class UsuariosCorrigido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioEmail",
                table: "Usuarios",
                type: "nvarchar(22)",
                maxLength: 22,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioEmail",
                table: "Usuarios");
        }
    }
}
