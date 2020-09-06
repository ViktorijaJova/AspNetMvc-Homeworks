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
        [HttpGet("Products")]
        public IActionResult Index()
        {

            var listofEscapeRoomsVM = new List<ProductViewModel>();

            foreach (var room in InMemoryDB.Database.EscapeRooms)
            {
                var roomVM = new ProductViewModel()
                {
                    Id = room.Id,
                    Name = room.Name,
                    Price = room.Price,
                    Description = room.Description,
                    Category = room.Category
            
                };

                listofEscapeRoomsVM.Add(roomVM);
            }


            ProductListViewModel productViewModel = new ProductListViewModel
            {
                TotalNumberOfRooms = InMemoryDB.Database.EscapeRooms.Count,
                EscapeRooms = listofEscapeRoomsVM

            };
            return View("Products", productViewModel);
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
            //add error handling
         
            Product newroom = new Product()
            {
                Id = InMemoryDB.Database.EscapeRooms.Count + 1,
                Name = createroom.Name,
                Category = createroom.Category,
                Price = createroom.Price,
                Description = createroom.Description
            };
           


            InMemoryDB.Database.EscapeRooms.Add(newroom);

            return View("ProductComplete");
        }
    }
}
