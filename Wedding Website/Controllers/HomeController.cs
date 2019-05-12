using System.Web.Mvc;

namespace Wedding_Website.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Each ActionResult has a ViewBag.BodyID = "***"; in order to tag the <html> tag in the layout page.  
        /// This is done to apply a css property that helps prevent a bug where scrolling to the bottom of the screen displays a white bar.
        /// </summary>
        /// <returns></returns>

        // http://jonathanschmiel.com/?portfolio=jj-liz-wedding-application
        // https://github.com/jjschmiel/Wedding-Web-App
        public ActionResult Index()
        {
            ViewBag.BodyID = "index";
            return View();
        }

        public ActionResult WhereWhen()
        {
            ViewBag.BodyID = "wherewhen";
            return View();
        }

        public ActionResult Error()
        {
            ViewBag.BodyID = "error";
            return View();
        }
    }
}