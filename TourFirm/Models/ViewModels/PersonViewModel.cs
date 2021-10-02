using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TourFirm.Models.ViewModels
{
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Введите имя!")]
        public string name { get; set; }

        public string family { get; set; }

        public string lastname { get; set; }

        public DateTime? datebirth { get; set; }

        public string passport { get; set; }


    }
}
