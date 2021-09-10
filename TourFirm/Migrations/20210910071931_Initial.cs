using Microsoft.EntityFrameworkCore.Migrations;

namespace TourFirm.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "CategoryRoomHotel",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CategoryRoomHotel", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CategoryServices",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false),
            //        CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ImageCategoryNamePath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CategoryServices", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CountryHotel",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CountryHotel", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Services",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdCategory = table.Column<short>(type: "smallint", nullable: false),
            //        Description = table.Column<string>(type: "text", nullable: true),
            //        IsPayed = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Services", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Services_CategoryServices",
            //            column: x => x.IdCategory,
            //            principalTable: "CategoryServices",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CitiesCountry",
            //    columns: table => new
            //    {
            //        Id = table.Column<short>(type: "smallint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdCountry = table.Column<short>(type: "smallint", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CitiesCountry", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CitiesCountry_CountryTour",
            //            column: x => x.IdCountry,
            //            principalTable: "CountryHotel",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Hotel",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        IdCity = table.Column<short>(type: "smallint", nullable: false),
            //        NameHotel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
            //        RatingHotel = table.Column<float>(type: "real", nullable: true),
            //        DistanceToSea = table.Column<short>(type: "smallint", nullable: true),
            //        LineNumber = table.Column<short>(type: "smallint", nullable: true),
            //        NeedVisa = table.Column<bool>(type: "bit", nullable: true),
            //        DescriptionTour = table.Column<string>(type: "text", nullable: true),
            //        PresentImagePath = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        IsSpecialPrice = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Hotel", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Tour_CitiesCountry",
            //            column: x => x.IdCity,
            //            principalTable: "CitiesCountry",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HotelPrices",
            //    columns: table => new
            //    {
            //        Int = table.Column<int>(type: "int", nullable: false),
            //        PriceDay = table.Column<decimal>(type: "money", nullable: true),
            //        IdHotel = table.Column<int>(type: "int", nullable: true),
            //        IdCategoryHotelNumber = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TourPrices", x => x.Int);
            //        table.ForeignKey(
            //            name: "FK_HotelPrices_CategoryRoomHotel",
            //            column: x => x.IdCategoryHotelNumber,
            //            principalTable: "CategoryRoomHotel",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_HotelPrices_Hotel",
            //            column: x => x.IdHotel,
            //            principalTable: "Hotel",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ImagesHotel",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdHotel = table.Column<int>(type: "int", nullable: true),
            //        ImagePathName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FolderPath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ImagesHotel", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ImagesHotel_Hotel",
            //            column: x => x.IdHotel,
            //            principalTable: "Hotel",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ServicesHotel",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdHotel = table.Column<int>(type: "int", nullable: true),
            //        IdService = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ServicesHotel", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ServicesTour_Services",
            //            column: x => x.IdService,
            //            principalTable: "Services",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_ServicesTour_Tour",
            //            column: x => x.IdHotel,
            //            principalTable: "Hotel",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_CitiesCountry_IdCountry",
            //    table: "CitiesCountry",
            //    column: "IdCountry");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Hotel_IdCity",
            //    table: "Hotel",
            //    column: "IdCity");

            //migrationBuilder.CreateIndex(
            //    name: "IX_HotelPrices_IdCategoryHotelNumber",
            //    table: "HotelPrices",
            //    column: "IdCategoryHotelNumber");

            //migrationBuilder.CreateIndex(
            //    name: "IX_HotelPrices_IdHotel",
            //    table: "HotelPrices",
            //    column: "IdHotel");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ImagesHotel_IdHotel",
            //    table: "ImagesHotel",
            //    column: "IdHotel");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Services_IdCategory",
            //    table: "Services",
            //    column: "IdCategory");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ServicesHotel_IdHotel",
            //    table: "ServicesHotel",
            //    column: "IdHotel");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ServicesHotel_IdService",
            //    table: "ServicesHotel",
            //    column: "IdService");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "HotelPrices");

            //migrationBuilder.DropTable(
            //    name: "ImagesHotel");

            //migrationBuilder.DropTable(
            //    name: "ServicesHotel");

            //migrationBuilder.DropTable(
            //    name: "CategoryRoomHotel");

            //migrationBuilder.DropTable(
            //    name: "Services");

            //migrationBuilder.DropTable(
            //    name: "Hotel");

            //migrationBuilder.DropTable(
            //    name: "CategoryServices");

            //migrationBuilder.DropTable(
            //    name: "CitiesCountry");

            //migrationBuilder.DropTable(
            //    name: "CountryHotel");
        }
    }
}
