using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedRealationBetweenPortfolioAndClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client",
                table: "Portfolios");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ClientId",
                table: "Portfolios",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_ClientId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
