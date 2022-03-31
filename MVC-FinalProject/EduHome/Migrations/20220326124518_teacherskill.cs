using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class teacherskill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Skills");

            migrationBuilder.CreateTable(
                name: "TeacherSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSkill_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkill_SkillId",
                table: "TeacherSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkill_TeacherId",
                table: "TeacherSkill",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSkill");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
