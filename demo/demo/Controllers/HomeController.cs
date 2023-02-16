using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Promo()
        {
           var dataSourceItem =  RenderingContext.Current.Rendering.Item;
            return View(dataSourceItem);
        }
    }
}