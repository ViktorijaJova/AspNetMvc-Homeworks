using AspNet.Mvc.EscapeRoomApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomApp.Models.ViewModels.AddProduct
{
    public class CreateProductViewModel
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Display(Name = "Address for delivery")]
        public string Description { get; set; }
        [Display(Name = "Phone Number")]
        public double Price { get; set; }
        [Display(Name = "Type of Pizza")]
        public Category Category { get; set; }
    }
}
