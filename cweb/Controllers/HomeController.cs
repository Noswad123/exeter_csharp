using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cweb.Models;
using PartyRSVP.Models;

namespace cweb.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Rsvp");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // Todo: Store guest response, covered in later lessons
            return View("Thanks", guestResponse);
        }
    }
}
