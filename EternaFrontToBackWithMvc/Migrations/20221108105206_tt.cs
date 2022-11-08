using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioGroupId",
                table: "PortfolioImages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioGroupId",
                table: "PortfolioImages",
                column: "PortfolioGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImages_PortfolioGroups_PortfolioGroupId",
                table: "PortfolioImages",
                column: "PortfolioGroupId",
                principalTable: "PortfolioGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImages_PortfolioGroups_PortfolioGroupId",
                table: "PortfolioImages");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioImages_PortfolioGroupId",
                table: "PortfolioImages");

            migrationBuilder.DropColumn(
                name: "PortfolioGroupId",
                table: "PortfolioImages");
        }
    }
}
