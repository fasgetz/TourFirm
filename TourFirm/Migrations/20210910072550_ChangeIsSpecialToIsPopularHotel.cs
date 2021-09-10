using Microsoft.EntityFrameworkCore.Migrations;

namespace TourFirm.Migrations
{
    public partial class ChangeIsSpecialToIsPopularHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSpecialPrice",
                table: "Hotel",
                newName: "IsPopular");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPopular",
                table: "Hotel",
                newName: "IsSpecialPrice");
        }
    }
}
