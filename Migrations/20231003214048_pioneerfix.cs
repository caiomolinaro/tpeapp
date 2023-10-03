using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class pioneerfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPionerAndMinisterialServante",
                table: "Privileges",
                newName: "IsPioneerAndMinisterialServante");

            migrationBuilder.RenameColumn(
                name: "IsPioner",
                table: "Privileges",
                newName: "IsPioneer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPioneerAndMinisterialServante",
                table: "Privileges",
                newName: "IsPionerAndMinisterialServante");

            migrationBuilder.RenameColumn(
                name: "IsPioneer",
                table: "Privileges",
                newName: "IsPioner");
        }
    }
}
