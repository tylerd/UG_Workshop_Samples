using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WpgNetUserGroup_Web.Data;
using WpgNetUserGroup_Web.Models;

namespace WpgNetUserGroup_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dataContext = new DataContext();

            var meeting = new Meeting { Title = "A User Group Event", Location = "Smart Park", Date = DateTime.Now.AddDays(1) };

            dataContext.AddMeeting(meeting);

            dataContext.SaveChanges();

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
