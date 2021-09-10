using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelPrices = new HashSet<HotelPrice>();
            ImagesHotels = new HashSet<ImagesHotel>();
            ServicesHotels = new HashSet<ServicesHotel>();
        }

        public int Id { get; set; }
        public short IdCity { get; set; }
        public string NameHotel { get; set; }
        public float? RatingHotel { get; set; }
        public short? DistanceToSea { get; set; }
        public short? LineNumber { get; set; }
        public bool? NeedVisa { get; set; }
        public string DescriptionTour { get; set; }
        public string PresentImagePath { get; set; }
        public bool? IsPopular { get; set; }

        public virtual CitiesCountry IdCityNavigation { get; set; }
        public virtual ICollection<HotelPrice> HotelPrices { get; set; }
        public virtual ICollection<ImagesHotel> ImagesHotels { get; set; }
        public virtual ICollection<ServicesHotel> ServicesHotels { get; set; }
    }
}
