using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;

namespace TourFirm.Services
{
    public interface ICountryCitiesService
    {

        /// <summary>
        /// Получить список стран
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<CountryHotel>> GetCountriesTours();


        /// <summary>
        /// Получить список стран, у которых есть отели
        /// </summary>
        /// <param name="hasHotels">Есть отели</param>
        /// <returns></returns>
        public Task<IEnumerable<CountryHotel>> GetCountriesTours(bool hasHotels);
    }
}
