using Microsoft.AspNetCore.Mvc;
using onlineMoviesTickets.Services;

namespace onlineMoviesTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly ActorService _actService;
        public ActorController(ActorService actorService)
        {
            _actService= actorService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actService.GetAllActors();
            return View(data);
        }
        public async Task<IActionResult> Edit()
        {
            return View();
        }
    }
}
