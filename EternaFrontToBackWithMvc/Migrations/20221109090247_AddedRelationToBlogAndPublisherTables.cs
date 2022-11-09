using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class AddedRelationToBlogAndPublisherTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Publishers_PublisherId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PublisherId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Blogs");
        }
    }
}
