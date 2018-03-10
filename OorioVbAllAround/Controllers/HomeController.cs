using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BLL;

namespace OorioVbAllAround.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contents = MockData.mockContent();
            
            ViewBag.Contents = contents;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}