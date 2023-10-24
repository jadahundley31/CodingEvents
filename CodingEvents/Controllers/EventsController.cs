using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> Events = new List<string>();

            Events.Add("Code With Pride");
            Events.Add("Strange Loop");
            Events.Add("Women Who Code");

            ViewBag.events = Events;
            return View();
        }
    }
}

