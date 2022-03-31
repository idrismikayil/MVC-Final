using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class addSomeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(maxLength: 200, nullable: false),
                    Position = table.Column<string>(maxLength: 200, nullable: false),
                    About = table.Column<string>(maxLength: 1000, nullable: false),
                    Degree = table.Column<string>(maxLength: 200, nullable: false),
                    Experience = table.Column<string>(maxLength: 200, nullable: false),
                    Hobbies = table.Column<string>(maxLength: 200, nullable: false),
                    Faculty = table.Column<string>(maxLength: 200, nullable: false),
                    LanguageLevel = table.Column<string>(maxLength: 200, nullable: false),
                    DesignLevel = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    FirstSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: false),
                    SecondSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: false),
                    ThirdSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: false),
                    FourthSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: false),
                    FirstURL = table.Column<string>(maxLength: 200, nullable: false),
                    SecondURL = table.Column<string>(maxLength: 200, nullable: false),
                    ThirdURL = table.Column<string>(maxLength: 200, nullable: false),
                    FourthURL = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WelcomeMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WelcomeMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(maxLength: 200, nullable: false),
                    SkillPercent = table.Column<int>(maxLength: 200, nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Skype = table.Column<string>(maxLength: 200, nullable: true),
                    FirstSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: true),
                    SecondSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: true),
                    ThirdSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: true),
                    FourthSocialMediaLogo = table.Column<string>(maxLength: 200, nullable: true),
                    FirstURL = table.Column<string>(maxLength: 200, nullable: true),
                    SecondURL = table.Column<string>(maxLength: 200, nullable: true),
                    ThirdURL = table.Column<string>(maxLength: 200, nullable: true),
                    FourthURL = table.Column<string>(maxLength: 200, nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherContact_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherContact_TeacherId",
                table: "TeacherContact",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TeacherContact");

            migrationBuilder.DropTable(
                name: "WelcomeMessages");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
