using Microsoft.EntityFrameworkCore.Migrations;

namespace DKPortfolio.Data.Migrations
{
    public partial class update_Articles_Add_ImgLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgLink",
                table: "Articles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgLink",
                table: "Articles");
        }
    }
}
