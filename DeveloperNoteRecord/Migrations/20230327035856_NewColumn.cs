using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperNoteRecord.Migrations
{
    public partial class NewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeveloperSkillDeveloperId",
                table: "DeveloperSkill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeveloperSkillSkillSetId",
                table: "DeveloperSkill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperSkill_DeveloperSkillDeveloperId_DeveloperSkillSkillSetId",
                table: "DeveloperSkill",
                columns: new[] { "DeveloperSkillDeveloperId", "DeveloperSkillSkillSetId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperSkill_DeveloperSkill_DeveloperSkillDeveloperId_DeveloperSkillSkillSetId",
                table: "DeveloperSkill",
                columns: new[] { "DeveloperSkillDeveloperId", "DeveloperSkillSkillSetId" },
                principalTable: "DeveloperSkill",
                principalColumns: new[] { "DeveloperId", "SkillSetId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperSkill_DeveloperSkill_DeveloperSkillDeveloperId_DeveloperSkillSkillSetId",
                table: "DeveloperSkill");

            migrationBuilder.DropIndex(
                name: "IX_DeveloperSkill_DeveloperSkillDeveloperId_DeveloperSkillSkillSetId",
                table: "DeveloperSkill");

            migrationBuilder.DropColumn(
                name: "DeveloperSkillDeveloperId",
                table: "DeveloperSkill");

            migrationBuilder.DropColumn(
                name: "DeveloperSkillSkillSetId",
                table: "DeveloperSkill");
        }
    }
}
