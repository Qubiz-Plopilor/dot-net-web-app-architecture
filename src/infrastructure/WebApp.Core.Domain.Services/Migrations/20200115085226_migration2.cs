using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Core.Domain.Services.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleImage",
                table: "Article",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Article",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleImage",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Article");
        }
    }
}
