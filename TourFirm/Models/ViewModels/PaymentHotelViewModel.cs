using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourFirm.Models.ViewModels
{
    public partial class PaymentHotelViewModel
    {
        /// <summary>
        /// Количество дней
        /// </summary>
        [Required]
        public int days { get; set; }
        
        
        /// <summary>
        /// Количество людей
        /// </summary>
        [Required]
        public int humans { get; set; }

        /// <summary>
        /// Номер-класс отеля, который оплачиваем
        /// </summary>
        [Required]
        public int numberhotelclass { get; set; }


        /// <summary>
        /// Данные на людей
        /// </summary>
        [Required]
        public PersonViewModel[] persons { get; set; }


    }
}
