using Microsoft.AspNetCore.Mvc;

namespace onlineMoviesTickets.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
