using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UIRouteNavigationMenu.Controllers
{
    public class RootController : Controller
    {
        // GET: Root
        public ActionResult Shell()
        {
            return View();
        }
    }
}