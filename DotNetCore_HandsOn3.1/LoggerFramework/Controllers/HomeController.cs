using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoggerFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _logger;

        public HomeController()
        {
            _logger = LogManager.GetLogger(typeof(HomeController));
        }

        public ActionResult Index()
        {
            _logger.Error("Index page log");
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