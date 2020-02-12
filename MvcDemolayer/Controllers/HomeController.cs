using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemolayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string mvcVersion = typeof(Controller).Assembly.GetName().Version.ToString();
            return mvcVersion;
        }
        public string Value(string id)
        {
            string mvcVersion = typeof(Controller).Assembly.GetName().Version.ToString();
            return "version= "+mvcVersion+" ID= "+id;
        }
        public ActionResult View()
        {
            return View();
        }
    }
}