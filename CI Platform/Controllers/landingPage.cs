using Microsoft.AspNetCore.Mvc;

namespace CI_Platform.Controllers
{
    public class landingPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MissionPage()
        {
            return View("MissionPage");
        }
    }
}
