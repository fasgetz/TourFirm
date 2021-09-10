using Microsoft.EntityFrameworkCore.Migrations;

namespace TourFirm.Migrations
{
    public partial class ChangeIntToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Int",
                table: "HotelPrices",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HotelPrices",
                newName: "Int");
        }
    }
}
