using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Services;

namespace TourFirm.Controllers
{
    public class CountryCitiesController : Controller
    {
        private readonly ICountryCitiesService service;

        public CountryCitiesController(ICountryCitiesService service)
        {
            this.service = service;
        }


        /// <summary>
        /// Получить список стран по турам
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCountriesTour()
        {
            var countries = await service.GetCountriesTours(true);


            return Ok(countries);
        }
    }
}
