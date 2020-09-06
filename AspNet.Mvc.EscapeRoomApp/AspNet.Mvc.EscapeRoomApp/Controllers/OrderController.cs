using AspNet.Mvc.EscapeRoomApp.InMemoryDB;
using AspNet.Mvc.EscapeRoomApp.Models.Domain;
using AspNet.Mvc.EscapeRoomApp.Models.ViewModels;
using AspNet.Mvc.EscapeRoomApp.Models.ViewModels.AddProduct;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomApp.Controllers
{
    public class OrderController : Controller
    {

      /*  [HttpGet("Orders")]
        public IActionResult Index()
        {
            Order firstorder = InMemoryDataBase.Database.Orders.FirstOrDefault();

            var listofOrderVM = new List<OrderViewModel>();

            foreach (var order in InMemoryDataBase.Database.Orders)
            {
                var orderVM = new OrderViewModel()
                {
                    Id = order.Id,
                    Delivered = order.Delivered,
                    Pizza = new PizzaViewModel
                    {
                        Id = order.Pizza.Id,
                        Name = order.Pizza.Name,
                        Price = order.Pizza.Price,
                        Size = order.Pizza.Size
                    },
                    Price = order.Price,
                    User = new UserViewModel
                    {
                        Id = order.User.Id,
                        Address = order.User.Address,
                        FirstName = order.User.FirstName,
                        LastName = order.User.LastName,
                        Phone = order.User.Phone
                    }
                };

                listofOrderVM.Add(orderVM);
            }


            OrderListViewModel orderViewModel = new OrderListViewModel
            {
                FirstPersonName = $"{firstorder.User.FirstName}{firstorder.User.LastName}",
                NumberOfOrders = InMemoryDataBase.Database.Orders.Count,
                FirstPizza = firstorder.Pizza.Name,
                Orders = listofOrderVM

            };


            ViewBag.Title = "Welcome to the Orders page!";
            return View("Orders", orderViewModel);
        }*/


        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
           // ViewBag.Error = error;
            return View();
        }
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductViewModel createorder)
        {
            var pizza = InMemoryDB.Database.EscapeRooms.FirstOrDefault(p => p.Category == createorder.Category);
            //some error handling

            if (pizza == null)
            {
                return RedirectToAction("CreateProduct", new { error = "There is no pizza like that in the menu" });
            }
         

            var order = new Product
            {
                Id = InMemoryDB.Database.EscapeRooms.Count + 1,
                Price = pizza.Price + 2,

            };

            InMemoryDB.Database.EscapeRooms.Add(order);

            return View("OrderComplete");
        }
    }

    /*        [HttpGet("Details")]
            public IActionResult GetDetails()
            {
                List<Product> listOfProductDto = new List<Product>();

                foreach (Product product in InMemoryDB.Database.EscapeRooms)
                {
                    Product productDto = new Product()
                    {
                        Category = product.Category,
                        Description = product.Description,
                        Name = product.Name,
                        Price = product.Price
                    };
                    listOfProductDto.Add(productDto);
                }

                // dali postoi nacin enumot vo json-ot da go dade vo negovata string reprezentacija a ne vo int reprezentacijata kako sto go dava?
                return Json(listOfProductDto);
            }
        }*/
}

