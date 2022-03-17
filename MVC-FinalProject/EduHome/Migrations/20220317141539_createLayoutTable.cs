using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class createLayoutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavLogo = table.Column<string>(maxLength: 200, nullable: false),
                    FooterLogo = table.Column<string>(maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Layout", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Layout");
        }
    }
}
