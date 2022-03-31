using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class edit8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BottomTitle",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BottomTitle",
                table: "Sliders",
                type: "nvarchar(170)",
                maxLength: 170,
                nullable: false,
                defaultValue: "");
        }
    }
}
