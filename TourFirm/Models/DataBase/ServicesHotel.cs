using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class ServicesHotel
    {
        public int Id { get; set; }
        public int? IdHotel { get; set; }
        public short? IdService { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
    }
}
