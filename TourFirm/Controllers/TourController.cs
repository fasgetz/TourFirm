using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models;
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


        /// <summary>
        /// Поиск отелей по параметрам
        /// </summary>
        /// <param name="idCountry">Номер страны</param>
        /// <param name="days"></param>
        /// <param name="countHumans"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> getSearchHotels(int idCountry, int days, int countHumans)
        {
            IEnumerable<Hotel> hotels = await tourService.GetHotels(idCountry);

            var list = hotels.Select(hotel => new
            {
                Id = hotel.Id,
                country = hotel.IdCityNavigation.IdCountryNavigation.Name,
                city = hotel.IdCityNavigation.Name,
                minPriceDay = hotel.HotelPrices.Min(i => i.PriceDay),
                imagePath = hotel.PresentImagePath,
                randDays = days,
                HotelName = hotel.NameHotel,
                countHumans = countHumans,
                RatingHotel = (int)hotel.RatingHotel
            });

            return Ok(list);
        }

        /// <summary>
        /// Получить список туров
        /// </summary>
        /// <param name="idCountry">Номер страны</param>
        /// <param name="days"> количество дней</param>
        /// <param name="countHumans">Количество человек</param>
        /// <returns></returns>
        public IActionResult Search(int idCountry, int days, int countHumans)
        {
            ViewBag.idCountry = idCountry;
            ViewBag.days = days;
            ViewBag.countHumans = countHumans;

            return View();
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
