using Microsoft.EntityFrameworkCore.Migrations;

namespace Eatery.Migrations
{
    public partial class ediEatingTRtpe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "EatingTypes",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heading",
                table: "EatingTypes");
        }
    }
}
