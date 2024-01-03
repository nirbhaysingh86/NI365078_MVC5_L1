using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOWRunAssignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Welcome()
        {
            int hour = DateTime.Now.Hour;
            ViewData["greeting"] = (hour < 12 ? "Good morning" : "Good afternoon");
            return View();
        }
    }
}