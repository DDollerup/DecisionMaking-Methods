using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecisionMaking_Methods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id = -1)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult GetNumbers(int number1, int number2)
        {
            int result = number1 + number2;

            return RedirectToAction("Index", "Home", new { id = result });
        }
    }
}