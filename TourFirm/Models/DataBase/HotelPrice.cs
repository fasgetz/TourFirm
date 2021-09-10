using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class HotelPrice
    {
        public int Id { get; set; }
        public decimal? PriceDay { get; set; }
        public int? IdHotel { get; set; }
        public short? IdCategoryHotelNumber { get; set; }

        public virtual CategoryRoomHotel IdCategoryHotelNumberNavigation { get; set; }
        public virtual Hotel IdHotelNavigation { get; set; }
    }
}
