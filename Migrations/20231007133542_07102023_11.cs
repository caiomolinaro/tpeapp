using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.CreateTable(
                name: "UsersPrivileges",
                columns: table => new
                {
                    PrivilegesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPublisher = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneer = table.Column<bool>(type: "bit", nullable: false),
                    IsMinisterialServant = table.Column<bool>(type: "bit", nullable: false),
                    IsElder = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneerAndMinisterialServant = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneerAndElder = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPrivileges", x => x.PrivilegesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersPrivileges");

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    PrivilegesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsElder = table.Column<bool>(type: "bit", nullable: false),
                    IsMinisterialServant = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneer = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneerAndElder = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneerAndMinisterialServant = table.Column<bool>(type: "bit", nullable: false),
                    IsPublisher = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.PrivilegesId);
                });
        }
    }
}
