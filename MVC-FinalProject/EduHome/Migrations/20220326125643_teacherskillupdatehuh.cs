using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class teacherskillupdatehuh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillPercent",
                table: "Skills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillPercent",
                table: "Skills",
                type: "int",
                maxLength: 200,
                nullable: false,
                defaultValue: 0);
        }
    }
}
