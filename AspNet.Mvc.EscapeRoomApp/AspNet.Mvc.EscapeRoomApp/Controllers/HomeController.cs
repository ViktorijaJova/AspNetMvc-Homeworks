using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNet.Mvc.EscapeRoomApp.Models;
using AspNet.Mvc.EscapeRoomApp.Models.ViewModels.AddProduct;
using AspNet.Mvc.EscapeRoomApp.InMemoryDB;
using AspNet.Mvc.EscapeRoomApp.Models.Domain;
using AspNet.Mvc.EscapeRoomApp.Models.ViewModels;

namespace AspNet.Mvc.EscapeRoomApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<ProductViewModel> listOfProductVM = new List<ProductViewModel>();

            ProductViewModel productVM = new ProductViewModel();


         foreach (Product product in InMemoryDB.Database.EscapeRooms)
            {
                productVM = new ProductViewModel()
                {
                    Id = product.Id,
                    Category = product.Category,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price
                };
                listOfProductVM.Add(productVM);
            }

            ProductListViewModel productListVM = new ProductListViewModel()
            {
                TotalNumberOfProducts = InMemoryDB.Database.EscapeRooms.Count,
                Products = listOfProductVM
            };

            return View("Index", productListVM);
        }
    
    public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
