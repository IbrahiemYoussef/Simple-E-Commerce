using Microsoft.EntityFrameworkCore;
using onlineMoviesTickets.Data;
using onlineMoviesTickets.Models;

namespace onlineMoviesTickets.Services
{
    public class ProducerService
    {
        private readonly MyDbContext _context;
        public ProducerService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Producer>> GetAllProducers()
        {
            return await _context.Producers.ToListAsync();
        }
    }
}
