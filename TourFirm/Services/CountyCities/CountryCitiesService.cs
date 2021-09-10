using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;

namespace TourFirm.Services.CountyCities
{
    public class CountryCitiesService : ICountryCitiesService
    {
        private readonly TourFirmDBContext db;

        public CountryCitiesService(TourFirmDBContext db)
        {
            this.db = db;
        }



        /// <summary>
        /// Получить список стран
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CountryHotel>> GetCountriesTours()
        {
            IQueryable<CountryHotel> query = db.CountryHotels;


            return await query.ToListAsync();
        }




        /// <summary>
        /// Получить список стран, у которых есть отели
        /// </summary>
        /// <param name="hasHotels">Есть отели</param>
        /// <returns></returns>
        public async Task<IEnumerable<CountryHotel>> GetCountriesTours(bool hasHotels)
        {
            IQueryable<CountryHotel> query = db.CountryHotels;

            if (hasHotels != false)
            {
                query = db.CountryHotels.Where(i => i.CitiesCountries.Where(s => s.Hotels.Count() != 0).Count() != 0);
            }


            return await query.ToListAsync();
        }


    }
}
