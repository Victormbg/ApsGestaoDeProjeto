using Microsoft.AspNetCore.Mvc;
using StarTrek.Data;

namespace StarTrek.Controllers
{
    public class NaveController : Controller
    {
        private readonly ApplicationDbContext _db;
        public NaveController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objNaveList = _db.Naves.ToList();
            return View();
        }
    }
}
