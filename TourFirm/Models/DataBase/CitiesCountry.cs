using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class CitiesCountry
    {
        public CitiesCountry()
        {
            Hotels = new HashSet<Hotel>();
        }

        public short Id { get; set; }
        public short? IdCountry { get; set; }
        public string Name { get; set; }

        public virtual CountryHotel IdCountryNavigation { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
