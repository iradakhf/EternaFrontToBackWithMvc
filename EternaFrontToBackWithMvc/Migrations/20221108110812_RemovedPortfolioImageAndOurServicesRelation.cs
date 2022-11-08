using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class RemovedPortfolioImageAndOurServicesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImages_OurServices_OurServiceId",
                table: "PortfolioImages");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioImages_OurServiceId",
                table: "PortfolioImages");

            migrationBuilder.DropColumn(
                name: "OurServiceId",
                table: "PortfolioImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OurServiceId",
                table: "PortfolioImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_OurServiceId",
                table: "PortfolioImages",
                column: "OurServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImages_OurServices_OurServiceId",
                table: "PortfolioImages",
                column: "OurServiceId",
                principalTable: "OurServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
