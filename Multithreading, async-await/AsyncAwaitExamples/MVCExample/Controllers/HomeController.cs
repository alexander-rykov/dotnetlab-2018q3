using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MVCExample.Services;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bll = new BusinessLayer.BLL();

            ViewBag.Result = bll.Do().DomainField;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}