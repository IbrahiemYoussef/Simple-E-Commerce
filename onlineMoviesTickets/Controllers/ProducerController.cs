using Microsoft.AspNetCore.Mvc;

namespace onlineMoviesTickets.Controllers
{
    public class ProducerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
