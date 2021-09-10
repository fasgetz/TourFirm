using Microsoft.EntityFrameworkCore.Migrations;

namespace TourFirm.Migrations
{
    public partial class AddIdentityPKHotelPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "Id",
            //    table: "HotelPrices",
            //    newName: "Int");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Int",
            //    table: "HotelPrices",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "Int",
            //    table: "HotelPrices",
            //    newName: "Id");

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "HotelPrices",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
