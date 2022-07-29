using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlineMoviesTickets.Data;
using onlineMoviesTickets.Models;

namespace onlineMoviesTickets.Services
{
    public class ActorService
    {
        private readonly MyDbContext _context;
        public ActorService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            return await _context.Actors.ToListAsync();
        }
    }
}
