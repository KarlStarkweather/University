using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations
{
    public partial class ks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentLevelLevelId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentLevels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LevelName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLevels", x => x.LevelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentLevelLevelId",
                table: "Students",
                column: "StudentLevelLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelLevelId",
                table: "Students",
                column: "StudentLevelLevelId",
                principalTable: "StudentLevels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentLevels_StudentLevelLevelId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentLevels");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentLevelLevelId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentLevelLevelId",
                table: "Students");
        }
    }
}
