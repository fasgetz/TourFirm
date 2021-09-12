using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourFirm.Controllers
{
    public class OfertaController : Controller
    {

        /// <summary>
        /// Оферта обработки персональных данных
        /// </summary>
        /// <returns></returns>
        public IActionResult PersonalPrivacyOferta()
        {
            return View();
        }
    }
}
