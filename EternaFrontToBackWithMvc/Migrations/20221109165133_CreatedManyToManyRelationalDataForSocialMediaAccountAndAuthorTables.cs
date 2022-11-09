using Microsoft.EntityFrameworkCore.Migrations;

namespace EternaFrontToBackWithMvc.Migrations
{
    public partial class CreatedManyToManyRelationalDataForSocialMediaAccountAndAuthorTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorSocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: false),
                    SocialMediaAccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorSocialMediaAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorSocialMediaAccounts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorSocialMediaAccounts_SocialMediaAccounts_SocialMediaAccountId",
                        column: x => x.SocialMediaAccountId,
                        principalTable: "SocialMediaAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSocialMediaAccounts_AuthorId",
                table: "AuthorSocialMediaAccounts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorSocialMediaAccounts_SocialMediaAccountId",
                table: "AuthorSocialMediaAccounts",
                column: "SocialMediaAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorSocialMediaAccounts");
        }
    }
}
