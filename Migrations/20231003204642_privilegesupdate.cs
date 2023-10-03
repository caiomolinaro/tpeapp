using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class privilegesupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Privilegios");

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    PrivilegesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPublisher = table.Column<bool>(type: "bit", nullable: false),
                    IsPioner = table.Column<bool>(type: "bit", nullable: false),
                    IsMinisterialServant = table.Column<bool>(type: "bit", nullable: false),
                    IsElder = table.Column<bool>(type: "bit", nullable: false),
                    IsPionerAndMinisterialServante = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneerAndElder = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.PrivilegesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.CreateTable(
                name: "Privilegios",
                columns: table => new
                {
                    PrivilegiosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAnciao = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneiro = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneiroAndServo = table.Column<bool>(type: "bit", nullable: false),
                    IsPioneroAndAnciao = table.Column<bool>(type: "bit", nullable: false),
                    IsPublicador = table.Column<bool>(type: "bit", nullable: false),
                    IsServo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilegios", x => x.PrivilegiosId);
                });
        }
    }
}
