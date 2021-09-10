using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;

namespace TourFirm.Services
{
    public class TourService : ITourService
    {

        private readonly TourFirmDBContext db;


        public TourService(TourFirmDBContext db)
        {
            this.db = db;
        }

        



        /// <summary>
        /// Взять последние добавленные популярные туры
        /// </summary>
        /// <param name="count_take">Количество туров</param>
        /// <returns>Последние добавленные популярные туры</returns>
        public async Task<IEnumerable<Hotel>> GetLastPopularHotels(int count_take)
        {
            var hotels = await db.Hotels.Where(i => i.IsPopular == true).OrderByDescending(i => i.Id).Include("IdCityNavigation.IdCountryNavigation").Take(count_take).ToListAsync();


            return hotels;
        }


        /// <summary>
        /// Взять последние добавленные популярные туры
        /// </summary>
        /// <param name="count_take">Количество туров</param>
        /// <param name="prices">Учесть цены в выборке</param>
        /// <returns>Последние добавленные популярные туры</returns>
        public async Task<IEnumerable<Hotel>> GetLastPopularHotels(int count_take, bool prices = false)
        {
            IQueryable<Hotel> hotels = db.Hotels.Where(i => i.IsPopular == true).OrderByDescending(i => i.Id).Include("IdCityNavigation.IdCountryNavigation");


            // Если параметр prices добавлен, то присоединить таблицу цен отеля
            if (prices == true)
            {
                hotels = hotels.Include("HotelPrices");
            }


            return await hotels.Take(count_take).ToListAsync();
        }
    }
}
