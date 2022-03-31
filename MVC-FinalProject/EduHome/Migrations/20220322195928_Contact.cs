using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class Contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconOne = table.Column<string>(maxLength: 150, nullable: false),
                    IconTwo = table.Column<string>(maxLength: 150, nullable: false),
                    IconThree = table.Column<string>(maxLength: 150, nullable: false),
                    AddressOne = table.Column<string>(maxLength: 150, nullable: false),
                    AddressTwo = table.Column<string>(maxLength: 150, nullable: false),
                    Number = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
