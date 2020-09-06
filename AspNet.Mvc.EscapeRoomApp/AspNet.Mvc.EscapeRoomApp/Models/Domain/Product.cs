using AspNet.Mvc.EscapeRoomApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomApp.Models.Domain
{
    public class Product
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public double Price { get; set;}
        public string Description { get; set;}
        public Category Category { get; set;}
    }
}
