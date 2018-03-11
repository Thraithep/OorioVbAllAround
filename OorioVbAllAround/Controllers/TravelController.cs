using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OorioVbAllAround.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        public ActionResult Index()
        {
            ViewBag.Message = "Your Travel page.";
            return View();
        }

        public ActionResult TravelDetail(int ObjectID)
        {
            ViewBag.Message = "Travel detail is " + ObjectID;
            return View();
        }
    }
}