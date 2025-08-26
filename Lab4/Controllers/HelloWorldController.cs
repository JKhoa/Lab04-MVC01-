using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Index1
        public ActionResult Index1()
        {
            return View();
        }

        // GET: HelloWorld/Welcome?name=Scott&numTimes=4
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
