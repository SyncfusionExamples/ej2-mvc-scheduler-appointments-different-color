using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScheduleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<AppointmentData> final = new List<AppointmentData>();
            AppointmentData temp = new AppointmentData();
            temp.Id = 1;
            temp.StartTime = Convert.ToDateTime("3/2/20");
            temp.EndTime = Convert.ToDateTime("3/9/2020");
            temp.Subject = "Jorge Gonzalez - PTO";
            temp.CategoryColor = "#00bdae";

            final.Add(temp);

            AppointmentData temp1 = new AppointmentData();
            temp1.Id = 2;
            temp1.StartTime = Convert.ToDateTime("3/5/20");
            temp1.EndTime = Convert.ToDateTime("3/19/2020");
            temp1.Subject = "William Gundaker - PTO";
            temp1.CategoryColor = "#ea7a57";

            final.Add(temp1);

            ViewBag.appointments = final;
            return View();
        }
        
        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string CategoryColor { get; set; }
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