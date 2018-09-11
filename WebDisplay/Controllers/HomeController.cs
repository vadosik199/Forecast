using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicForecaster.ForecastMethods.Method;
using BasicForecaster.ForecastMethods.MethodInterface;
using BasicForecaster.Models;
using PagedList;
using PagedList.Mvc;

namespace WebDisplay.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            if (Request.IsAuthenticated)
            {
                return RedirectToRoute(new { controller = "Manage", action = "Index" });
            }
            return RedirectToRoute(new { controller = "Account", action = "Login" });
            //return View();
        }
    }
}