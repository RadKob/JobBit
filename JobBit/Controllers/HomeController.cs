using Microsoft.AspNetCore.Mvc;

namespace JobBit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
