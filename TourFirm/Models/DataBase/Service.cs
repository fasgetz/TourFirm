using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class Service
    {
        public Service()
        {
            ServicesHotels = new HashSet<ServicesHotel>();
        }

        public short Id { get; set; }
        public short IdCategory { get; set; }
        public string Description { get; set; }
        public bool? IsPayed { get; set; }

        public virtual CategoryService IdCategoryNavigation { get; set; }
        public virtual ICollection<ServicesHotel> ServicesHotels { get; set; }
    }
}
