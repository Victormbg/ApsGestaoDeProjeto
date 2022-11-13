using Microsoft.AspNetCore.Mvc;
using StarTrek.Data;
using StarTrek.Models;

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
            IEnumerable<Nave> objNaveList = _db.Naves.ToList();
            return View(objNaveList);
        }
    }
}
