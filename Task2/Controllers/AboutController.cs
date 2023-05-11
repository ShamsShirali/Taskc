using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
