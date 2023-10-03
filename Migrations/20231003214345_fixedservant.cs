using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class fixedservant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPioneerAndMinisterialServante",
                table: "Privileges",
                newName: "IsPioneerAndMinisterialServant");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPioneerAndMinisterialServant",
                table: "Privileges",
                newName: "IsPioneerAndMinisterialServante");
        }
    }
}
