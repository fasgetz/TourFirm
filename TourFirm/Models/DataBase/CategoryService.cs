using System;
using System.Collections.Generic;

#nullable disable

namespace TourFirm.Models.DataBase
{
    public partial class CategoryService
    {
        public CategoryService()
        {
            Services = new HashSet<Service>();
        }

        public short Id { get; set; }
        public string CategoryName { get; set; }
        public string ImageCategoryNamePath { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
