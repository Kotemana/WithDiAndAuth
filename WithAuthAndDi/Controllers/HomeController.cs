using ProjectBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WithAuthAndDi.Models;

namespace WithAuthAndDi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;
        public HomeController(ITestService testService)
        {
            _testService = testService;
        }
        public ActionResult Index()
        {
            var model = new TestModel();
            model.TestString = _testService.Test();
            return View(model);
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