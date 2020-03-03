using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _employee = null;

        public HomeController(IEmployee emoloyee)
        {
            _employee = emoloyee;

        }


        public ActionResult Index()
        {
            int count = _employee.GetTotalStudent();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}