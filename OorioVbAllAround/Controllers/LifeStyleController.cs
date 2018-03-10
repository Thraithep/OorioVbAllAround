using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OorioVbAllAround.Controllers
{
    public class LifeStyleController : Controller
    {
        // GET: LifeStyle
        public ActionResult Index()
        {
            ViewBag.Message = "Your LifeStyle page.";
            return View();
        }
    }
}