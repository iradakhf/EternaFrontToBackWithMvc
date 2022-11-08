using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedConnectionBetweenPortfolioAndPortfolioImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "PortfolioImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioImages_PortfolioId",
                table: "PortfolioImages",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioImages_Portfolios_PortfolioId",
                table: "PortfolioImages",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioImages_Portfolios_PortfolioId",
                table: "PortfolioImages");

            migrationBuilder.DropIndex(
                name: "IX_PortfolioImages_PortfolioId",
                table: "PortfolioImages");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "PortfolioImages");
        }
    }
}
