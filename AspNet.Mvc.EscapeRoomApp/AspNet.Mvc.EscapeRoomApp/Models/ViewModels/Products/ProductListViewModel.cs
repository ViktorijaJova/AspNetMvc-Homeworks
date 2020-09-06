using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomApp.Models.ViewModels.AddProduct
{
    public class ProductListViewModel
    {

        public int TotalNumberOfProducts { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
