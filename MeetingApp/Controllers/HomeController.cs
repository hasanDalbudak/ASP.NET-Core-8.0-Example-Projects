using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() //IActionResult --> View()'ı karşılar
        {
            // Gets the hour of right now
            int saat = DateTime.Now.Hour;

            //THIS PART USES STRING MODEL
            //var selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            //View(model: selamlama);

            //THIS PART USES ViewBag
            //ViewBag.Selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            //ViewBag.UserName = "Hasan";

            //THIS PART USES ViewData
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler":"Günaydın";
            //ViewData["UserName"] = "Hasan";

            int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount
            };


            return View(meetingInfo);
        
        }
    }
}