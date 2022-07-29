using Microsoft.AspNetCore.Mvc;

namespace onlineMoviesTickets.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
