using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DesignLevel",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstSocialMediaLogo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstURL",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FourthSocialMediaLogo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FourthURL",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LanguageLevel",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SecondSocialMediaLogo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SecondURL",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ThirdSocialMediaLogo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ThirdURL",
                table: "Teachers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DesignLevel",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstSocialMediaLogo",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstURL",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FourthSocialMediaLogo",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FourthURL",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LanguageLevel",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondSocialMediaLogo",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondURL",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdSocialMediaLogo",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdURL",
                table: "Teachers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
