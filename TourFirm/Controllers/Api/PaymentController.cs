using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourFirm.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TourFirm.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        [HttpGet("test")]
        public IActionResult test()
        {
            return Ok("tested");
        }

        [HttpPost("payHotel")]
        public IActionResult PayHotel(PaymentHotelViewModel model)
        {


            return Ok("success");
        }


    }
}
