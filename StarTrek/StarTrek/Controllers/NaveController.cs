using Microsoft.AspNetCore.Mvc;

namespace StarTrek.Controllers
{
    public class NaveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
