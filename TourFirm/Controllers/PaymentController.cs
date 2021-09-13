using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.ViewModels;
using TourFirm.Services;

namespace TourFirm.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ITourService service;

        public PaymentController(ITourService service)
        {
            this.service = service;
        }


        /// <summary>
        /// Страница оплаты
        /// </summary>
        /// <param name="idTour">Номер тура</param>
        /// <param name="days">Количество дней</param>
        /// <param name="humans">Количество людей</param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int idHotel, int days = 1, int humans = 1)
        {
            var hotel = await service.GetHotel(idHotel);

            if (hotel == null)
            {
                return BadRequest("Отель не найден");
            }            


            return View(hotel);
        }



        [HttpPost]
        public IActionResult PayHotel([FromBody]PaymentHotelViewModel model)
        {


            return Ok();
        }
    }
}
