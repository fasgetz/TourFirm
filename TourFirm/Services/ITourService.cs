using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.DataBase;

namespace TourFirm.Services
{
    public interface ITourService
    {


        /// <summary>
        /// Взять последние добавленные популярные туры
        /// </summary>
        /// <param name="count_take">Количество туров</param>
        /// <returns>Последние добавленные популярные туры</returns>
        public Task<IEnumerable<Hotel>> GetLastPopularHotels(int count_take);

        /// <summary>
        /// Взять последние добавленные популярные туры
        /// </summary>
        /// <param name="count_take">Количество туров</param>
        /// <param name="prices">Учесть цены в выборке</param>
        /// <returns>Последние добавленные популярные туры</returns>
        public Task<IEnumerable<Hotel>> GetLastPopularHotels(int count_take, bool prices = false);
    }
}
