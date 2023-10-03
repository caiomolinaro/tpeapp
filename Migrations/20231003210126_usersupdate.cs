using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class usersupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isMulher",
                table: "Usuarios",
                newName: "IsWpman");

            migrationBuilder.RenameColumn(
                name: "isHomem",
                table: "Usuarios",
                newName: "IsMan");

            migrationBuilder.RenameColumn(
                name: "UsuarioTelefone",
                table: "Usuarios",
                newName: "UserPhone");

            migrationBuilder.RenameColumn(
                name: "UsuarioNome",
                table: "Usuarios",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "UsuarioEmail",
                table: "Usuarios",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuarios",
                newName: "UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "UserBirthDate",
                table: "Usuarios",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserBirthDate",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "UserPhone",
                table: "Usuarios",
                newName: "UsuarioTelefone");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Usuarios",
                newName: "UsuarioNome");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Usuarios",
                newName: "UsuarioEmail");

            migrationBuilder.RenameColumn(
                name: "IsWpman",
                table: "Usuarios",
                newName: "isMulher");

            migrationBuilder.RenameColumn(
                name: "IsMan",
                table: "Usuarios",
                newName: "isHomem");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Usuarios",
                newName: "UsuarioId");
        }
    }
}
