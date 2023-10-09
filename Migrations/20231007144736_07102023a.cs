using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class _07102023a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersPrivileges");

            migrationBuilder.AddColumn<bool>(
                name: "IsElder",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMinisterialServant",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPioneer",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPioneerAndElder",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPioneerAndMinisterialServant",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublisher",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "UsersSchedules",
                columns: table => new
                {
                    UserSchedulesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserSchedulesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    Sunday = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSchedules", x => x.UserSchedulesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersSchedules");

            migrationBuilder.DropColumn(
                name: "IsElder",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsMinisterialServant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPioneer",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPioneerAndElder",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPioneerAndMinisterialServant",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPublisher",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UsersPrivileges",
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
                    table.PrimaryKey("PK_UsersPrivileges", x => x.PrivilegesId);
                });
        }
    }
}
