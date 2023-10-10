using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpeapp.Migrations
{
    /// <inheritdoc />
    public partial class datetimetest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UserBaptismDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UserBirthDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserBaptismDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserBirthDate",
                table: "Users");
        }
    }
}
