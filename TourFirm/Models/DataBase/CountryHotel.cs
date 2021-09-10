using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class CountryHotel
    {
        public CountryHotel()
        {
            CitiesCountries = new HashSet<CitiesCountry>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CitiesCountry> CitiesCountries { get; set; }
    }
}
