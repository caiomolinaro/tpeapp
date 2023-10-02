using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class PrivilegioMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Privilegios",
                columns: table => new
                {
                    PrivilegiosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPublicador = table.Column<bool>(type: "bit", nullable: true),
                    IsPioneiro = table.Column<bool>(type: "bit", nullable: true),
                    IsServo = table.Column<bool>(type: "bit", nullable: true),
                    IsAnciao = table.Column<bool>(type: "bit", nullable: true),
                    IsPioneiroAndServo = table.Column<bool>(type: "bit", nullable: true),
                    IsPioneroAndAnciao = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privilegios", x => x.PrivilegiosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Privilegios");
        }
    }
}
