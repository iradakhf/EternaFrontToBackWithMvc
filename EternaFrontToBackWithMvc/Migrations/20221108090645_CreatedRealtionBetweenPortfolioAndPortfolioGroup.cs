using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class CreatedRealtionBetweenPortfolioAndPortfolioGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Portfolios",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PortfolioGroupId",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_PortfolioGroupId",
                table: "Portfolios",
                column: "PortfolioGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_PortfolioGroups_PortfolioGroupId",
                table: "Portfolios",
                column: "PortfolioGroupId",
                principalTable: "PortfolioGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_PortfolioGroups_PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PortfolioGroupId",
                table: "Portfolios");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Clients_ClientId",
                table: "Portfolios",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
