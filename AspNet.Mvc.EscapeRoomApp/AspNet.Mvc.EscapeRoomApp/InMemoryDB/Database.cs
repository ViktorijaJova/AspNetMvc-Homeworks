using AspNet.Mvc.EscapeRoomApp.Models.Domain;
using AspNet.Mvc.EscapeRoomApp.Models.Enums;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomApp.InMemoryDB
{
    public static class Database
    {
        public static List<Product> EscapeRooms;


        static Database()
        {
        

            EscapeRooms = new List<Product>() {
            new Product()
            {
                Id = 1,
                Name = "Saw",
                Price = 17,
                Description = "Based on the Jigsaw thrilogy",
                Category = Category.Horror
            },
                new Product()
                {
                    Id = 2,
                    Name = "Indiana Jones",
                    Price = 18,
                 Description = "Based on the Indiana Jones thrology",
                Category = Category.Adventure
                },
                new Product()
                {
                    Id = 3,
                    Name = "Hunting of the Hill House",
                    Price = 9,
                  Description = "Based on Stephen King novels",
                Category = Category.Horror }
            };
        
        }
    }
}
