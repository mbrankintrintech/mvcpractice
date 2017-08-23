using OdeToFood.Filters;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //[Authorize]
        [Logging]
        public ActionResult Search(string name)
        {

            ViewBag.Cuisine = Server.HtmlEncode(name);

            return View();
        }





    }
}