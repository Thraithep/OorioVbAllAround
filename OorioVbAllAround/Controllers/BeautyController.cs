using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OorioVbAllAround.Controllers
{
    public class BeautyController : Controller
    {
        // GET: Beauty
        public ActionResult Index()
        {
            ViewBag.Message = "Your Beauty page.";
            return View();
        }
    }
}