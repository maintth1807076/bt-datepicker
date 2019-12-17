using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace daterangepickermvc.Controllers
{
    public class DaterangePickerController : Controller
    {
        // GET: DaterangePicker
        public ActionResult Index(DateTime? startDate, DateTime? endDate)
        {
            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;
            return View();
        }
    }
}