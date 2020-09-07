using AspNet.Mvc.EscapeRoomsApp.Models.Domain;
using AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomsApp.Controllers
{
    public class OrderController:Controller
    {
        [HttpGet("MoreDetails")]
        public IActionResult Index()
        {
            ProductViewModel escapeRoomVm = new ProductViewModel();
            List<ProductViewModel> escapeRoomsListVM = new List<ProductViewModel>();


            foreach (Product room in InMemoryDB.Database.EscapeRooms)
            {
                escapeRoomVm = new ProductViewModel()
                {
                    Description = room.Description
                };
                escapeRoomsListVM.Add(escapeRoomVm);
            }


            ProductListViewModel escapeRoomsList = new ProductListViewModel()
            {
                TotalNumberOfRooms = InMemoryDB.Database.EscapeRooms.Count,
                EscapeRooms = escapeRoomsListVM
            };

            return View("MoreDetails", escapeRoomsList);
        }



        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductViewModel createroom)
        {
         
            Product newroom = new Product()
            {
                Id = InMemoryDB.Database.EscapeRooms.Count + 1,
                Name = createroom.Name,
                Category = createroom.Category,
                Price = createroom.Price,
                Description = createroom.Description
            };
            if (newroom.Name == null || newroom.Description == null || newroom.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "Error! Your escape room was not created. Try again" });
            }
            else
            {
                InMemoryDB.Database.EscapeRooms.Add(newroom);
                return View("ProductComplete");
            }



        }
    }
}
