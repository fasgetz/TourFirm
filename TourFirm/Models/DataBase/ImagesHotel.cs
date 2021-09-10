using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class ImagesHotel
    {
        public int Id { get; set; }
        public int? IdHotel { get; set; }
        public string ImagePathName { get; set; }
        public string FolderPath { get; set; }

        public virtual Hotel IdHotelNavigation { get; set; }
    }
}
