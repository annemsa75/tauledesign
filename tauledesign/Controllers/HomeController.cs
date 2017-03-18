using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tauledesign.Models;

namespace tauledesign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Her kommer cv";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Work()
        {
            var list = new List<Article>
            {
                new Article {Title = "Kjole", Category = "Dresses", Ordinal = 1}
            };
            return View(list);
        }

    }
}