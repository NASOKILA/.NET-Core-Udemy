using Microsoft.EntityFrameworkCore.Migrations;

namespace BookList_MVC_Udemy.Migrations
{
    public partial class RequiredBookISBNStringLength4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avaliable",
                table: "Books",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Avaliable",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
