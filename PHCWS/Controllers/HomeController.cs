using System.Diagnostics;
using System.Web.Mvc;

namespace PHCWS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";
            Debug.Write("Welcome to Index. ");
            return View();
        }
        public ActionResult API()
        {
            //ViewBag.Title = "Home Page";
            Debug.Write("Welcome to API. ");
            return View();
        }
        public ActionResult About()
        {
            //ViewBag.Title = "Home Page";
            Debug.Write("Welcome to About. ");
            return View();
        }
        public ActionResult Service()
        {
            //ViewBag.Title = "Home Page";
            Debug.Write("Welcome to Service. ");
            return View();
        }
        public ActionResult Contact()
        {
            //ViewBag.Title = "Home Page";
            Debug.Write("Welcome to Contact. ");
            return View();
        }
    }
}
