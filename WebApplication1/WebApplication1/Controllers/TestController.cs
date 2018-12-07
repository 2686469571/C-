using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
      public string GesString()
        {
            return "lalala";
        }
        public Customer getCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "abc";
            c.Address = "def";
            return c;
        }
        public ActionResult GetView()
        {
            return View("MyView");
            
        }
    }
}