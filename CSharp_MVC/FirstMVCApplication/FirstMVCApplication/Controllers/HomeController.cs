using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            //  MVC uses the ViewBag object to pass data between Controller and View.
            ViewBag.Greeting =
                hour < 12 ? "Good Moring. Time is " + DateTime.Now.ToShortDateString()
                          : "Good Afternoon. Time is " + DateTime.Now.ToShortDateString();
            return View();
        }

    }
}
 