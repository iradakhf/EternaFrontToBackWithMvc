using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedImagePropertyToTheOurSkillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "OurSkills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "OurSkills");
        }
    }
}
