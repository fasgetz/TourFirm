using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class CategoryRoomHotel
    {
        public CategoryRoomHotel()
        {
            HotelPrices = new HashSet<HotelPrice>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HotelPrice> HotelPrices { get; set; }
    }
}
