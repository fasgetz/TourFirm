using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;
using TourFirm.Services;

namespace TourFirm.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourService tourService;

        public TourController(ITourService tourService)
        {
            this.tourService = tourService;
        }





        /// <summary>
        /// Получить рандомные туры
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> getRandomTours()
        {
            IEnumerable<Hotel> hotels = await tourService.GetRandomHotels(3, true);

            var list = hotels.Select(hotel => new
            {
                Id = hotel.Id,
                country = hotel.IdCityNavigation.IdCountryNavigation.Name,
                city = hotel.IdCityNavigation.Name,
                minPriceDay = hotel.HotelPrices.Min(i => i.PriceDay),
                imagePath = hotel.PresentImagePath,
                randDays = new Random().Next(5, 14),
                HotelName = hotel.NameHotel
            });


            return Ok(list);
        }


        /// <summary>
        /// Получить последние популярные туры
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        public async Task<IActionResult> getLastPopularTours()
        {
            IEnumerable<Hotel> hotels = await tourService.GetLastPopularHotels(3, true);

            var list = hotels.Select(hotel => new
            {
                Id = hotel.Id,
                country = hotel.IdCityNavigation.IdCountryNavigation.Name,
                city = hotel.IdCityNavigation.Name,
                minPriceDay = hotel.HotelPrices.Min(i => i.PriceDay),
                imagePath = hotel.PresentImagePath,
                randDays = new Random().Next(5, 14),
                HotelName = hotel.NameHotel
            });


            return Ok(list);
        }






        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> About(int idHotel)
        {
            var hotel = await tourService.GetHotel(idHotel);

            if (hotel == null)
            {
                return BadRequest("Номер отеля не найден в БД");
            }

            return View(hotel);
        }
    }
}
