using onlineshoppingstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlineshoppingstore.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Data()
        {
            var item = new Item
        {
            ItemId=1,
            CategoryId=1, 
            ProducerId=1,
            Title="Outifit ",
            Price= 100L,
            
        };
            return View();
        }
        
    }
}