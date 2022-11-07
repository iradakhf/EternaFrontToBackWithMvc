using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedNamePropertyToTheCountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Counts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Counts");
        }
    }
}
