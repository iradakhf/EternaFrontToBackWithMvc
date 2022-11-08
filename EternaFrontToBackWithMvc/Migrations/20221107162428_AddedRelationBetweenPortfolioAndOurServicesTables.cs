using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedRelationBetweenPortfolioAndOurServicesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "OurServices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OurServices_PortfolioId",
                table: "OurServices",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_OurServices_Portfolios_PortfolioId",
                table: "OurServices",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OurServices_Portfolios_PortfolioId",
                table: "OurServices");

            migrationBuilder.DropIndex(
                name: "IX_OurServices_PortfolioId",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "OurServices");
        }
    }
}
