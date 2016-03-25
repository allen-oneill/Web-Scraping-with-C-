using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleServer.Models;

namespace SampleServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SampleData SD = new SampleData();
            return View(SD);
        }


        public ActionResult FormData()
        {
            var FD = Request.Form;
            ViewBag.Name = FD.GetValues("UserName").First();
            ViewBag.Gender = FD.GetValues("Gender").First();
            return View("~/Views/Home/PostSuccess.cshtml");
        }

        public ActionResult ViewDetail(int id)
        {
            SampleData SD = new SampleData();
            SD.SetSelected(id);
            return View(SD);
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