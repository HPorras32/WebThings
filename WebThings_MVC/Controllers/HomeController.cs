using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebThings_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcercaDe()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacto()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}