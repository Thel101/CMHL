using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperNoteRecord.Migrations
{
    public partial class ManytoManyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeveloperSkill",
                columns: table => new
                {
                    DeveloperId = table.Column<int>(type: "int", nullable: false),
                    SkillSetId = table.Column<int>(type: "int", nullable: false),
                    Efficiency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperSkill", x => new { x.DeveloperId, x.SkillSetId });
                    table.ForeignKey(
                        name: "FK_DeveloperSkill_Developer_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperSkill_SkillSet_SkillSetId",
                        column: x => x.SkillSetId,
                        principalTable: "SkillSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperSkill_SkillSetId",
                table: "DeveloperSkill",
                column: "SkillSetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperSkill");

            migrationBuilder.DropTable(
                name: "SkillSet");
        }
    }
}
