﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourFirm.Controllers
{
    public class TourController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }
    }
}
