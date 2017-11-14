using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MissionAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mission()
        {
            ViewBag.Message = "Find Missions from around the world and learn more about them.";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "We set out to make information easier to find for prospective missionaries and their parents. Gone are the days of asking that step uncle if his daughter needed rain boots in your mission 12 years ago. Find the information you need or post a question that other missionaries can answer too.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Reach out to us through email, phone, or stop by our office with any inquiries or requests.";
            var list = new SelectList(new[]
                {
                new { ID = "1", Name = "Clothing" },
                new { ID = "2", Name = "Weather" },
                new { ID = "3", Name = "Transportation" },
                new { ID = "4", Name = "Other" }
                },
            "ID", "Name");
            ViewData["list"] = list;
            return View();
        }
    }
}