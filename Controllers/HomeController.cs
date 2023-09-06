using Microsoft.AspNetCore.Mvc;

using MeetinApp.Models;

namespace MeetinApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"]= saat > 12 ? "İyi günler" : "Günaydın";
           // ViewData["UserName"] = "Selenay";

            MeetingInfo meetingInfo = new MeetingInfo()
            {


                Id = 1,
                Location = "İSTANBUL,ABC kongre merk,",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100

            };

            return View(meetingInfo);

        }
           
        }
    }

