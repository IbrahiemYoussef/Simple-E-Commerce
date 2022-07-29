using Microsoft.AspNetCore.Mvc;
using onlineMoviesTickets.Services;

namespace onlineMoviesTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ProducerService _producerService;
        public ProducerController(ProducerService producerService)
        {
            _producerService = producerService;
        }
        public async Task<IActionResult> Index()
        {
            var allproducers= await _producerService.GetAllProducers();
            return View(allproducers);
        }
    }
}
