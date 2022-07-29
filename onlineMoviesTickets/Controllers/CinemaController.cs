using Microsoft.AspNetCore.Mvc;

namespace onlineMoviesTickets.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
