using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Core.Entities;
using System;
using System.Diagnostics.Metrics;

namespace OrderProcessing.Web.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
            List<Item> lists = new List<Item>();
            lists.Add(new Item() { Id=1,Name = "pen", Description = "teste", Quantity=1,Price=50,IsAvailable=true });
            lists.Add(new Item() { Id = 2, Name = "pencil", Description = "teste", Quantity = 2, Price = 50, IsAvailable = true });
            lists.Add(new Item() { Id = 3, Name = "book", Description = "teste", Quantity = 4, Price = 50, IsAvailable = true });
            var model = new OrderProcess();
           model.CustomerID = 1;  //for now static, we can get from login 
           model.itemList = lists;
            return View(model);
        }

        [HttpPost]
        public ActionResult SaveOrder([FromBody] OrderProcess op)
        {
            // do something
            return Json(new EmptyResult());
        }



    }
}
