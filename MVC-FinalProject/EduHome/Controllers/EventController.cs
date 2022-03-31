using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Event events = await _context.Events.FirstOrDefaultAsync(c => c.Id == id);

            EventDetailVM model = new EventDetailVM
            {
                Event = events,
                Speakers = await _context.Speakers.Include(c => c.EventSpeakers).
                Where(c => c.EventSpeakers.Select(c => c.EventId).Contains(id)).ToListAsync(),
            };

            return View(model);
        }
    }
}
