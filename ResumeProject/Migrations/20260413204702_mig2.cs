using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeProject.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Portfolios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_CategoryId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Portfolios");
        }
    }
}
