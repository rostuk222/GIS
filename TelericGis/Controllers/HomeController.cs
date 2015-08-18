using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelericGis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is going to be a GISystem portal for something ...";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Just info for a page ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "In order to contact us";

            return View();
        }
    }
}
