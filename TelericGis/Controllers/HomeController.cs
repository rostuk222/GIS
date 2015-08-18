using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelericGis.Models;
using TelericGis.Services;

namespace TelericGis.Controllers
{
    public class HomeController : Controller
    {
        static GIS_DBEntities entities = new GIS_DBEntities();
        StreetRadiationService streetRadiationService = new StreetRadiationService(entities);

        public ActionResult Index()
        {
            var model = streetRadiationService.Read();
            ViewBag.Message = "This is going to be a GISystem portal for something ...";

            return View(model);
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
