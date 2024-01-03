 
using NI365078_MVC5_L1.Filter;
 
using System.Web.Mvc;
 

namespace NI365078_MVC5_L1.Controllers
{
    [TimeTrackerFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             
            return View();
        }
        [DontTrackTheTime]
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