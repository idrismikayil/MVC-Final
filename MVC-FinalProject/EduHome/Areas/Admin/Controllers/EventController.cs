using EduHome.Areas.Admin.ViewModels;
using EduHome.Constants;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.FileUtilities;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]

    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public EventController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Event> events = await _context.Events.ToListAsync();
            return View(events);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Event events = await _context.Events.FindAsync(id);

            EventVM model = new EventVM
            {
                Event = events,
                Speakers = await _context.Speakers.Include(c => c.EventSpeakers).
                Where(c => c.EventSpeakers.Select(c => c.EventId).Contains(id)).ToListAsync(),
            };

            return View(model);
        }
        public async Task<IActionResult> Update(int id)
        {
            Event events = await _context.Events.Include(e=> e.EventSpeakers).ThenInclude(ts=> ts.Speaker).FirstOrDefaultAsync(x=> x.Id == id);
            if (events == null) return NotFound();

            List<Speaker> speakers = new List<Speaker>();
            foreach (var item in events.EventSpeakers)
            {
                speakers.Add(item.Speaker);
            }

            EventVM model = new EventVM();
            model.Event = events;
            model.Speakers = _context.Speakers.ToList();
            model.SpeakerIds = speakers.Select(x=>x.Id).ToList();
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int id, EventVM events)
        {
            List<Speaker> speakers = new List<Speaker>();


            var oldSpeakersIds = await _context.EventSpeakers.Where(x => x.EventId == events.Event.Id).Select(x => x.SpeakerId).ToListAsync();

            foreach (var oldId in oldSpeakersIds)
            {
                 EventSpeaker oldEventSpeaker = await _context.EventSpeakers.FirstOrDefaultAsync(x=>x.SpeakerId == oldId && x.EventId == events.Event.Id);
                 _context.EventSpeakers.Remove(oldEventSpeaker);
            }

            foreach (var newId in events.SpeakerIds)
            {
                EventSpeaker eventSpeaker = new EventSpeaker() { EventId = events.Event.Id, SpeakerId = newId };
                await _context.EventSpeakers.AddAsync(eventSpeaker);
            }

            //if (!ModelState.IsValid) return View(events);


            if (events.Event.Id != id) return BadRequest();

            if (!events.Event.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Event.ImageFile), "File type is unsupported, please select image");
                return View(events);
            }
            if (events.Event.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Event.ImageFile), "File size cannot be greater than 1 mb");
                return View(events);
            }

            events.Event.Image = FileUtils.Create(FileConstants.ImagePathEvent, events.Event.ImageFile);

            EventVM model = new EventVM
            {
                Event = events.Event,
                Speakers = await _context.Speakers.Include(c => c.EventSpeakers).ThenInclude(s=> s.Speaker)
                .Where(c => c.EventSpeakers.Select(c => c.EventId).Contains(id)).ToListAsync()
            };

            bool isExist = await _context.Events.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Events.Update(events.Event);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create()
        {
            EventPostVM model = new EventPostVM
            {
                Speakers = await _context.Speakers.ToListAsync(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventPostVM model)
        {
            model.Speakers = await _context.Speakers.ToListAsync();
            //if (!ModelState.IsValid) return View(model);

            List<EventSpeaker> speakers = new List<EventSpeaker>();
            foreach (var speakerId in model.SpeakerIds)
            {
                var speaker = await _context.Speakers.FindAsync(speakerId);
                if (speaker == null)
                {
                    ModelState.AddModelError(nameof(EventPostVM.SpeakerIds), "Choose a valid speaker");
                    return View(model);
                }
                speakers.Add(new EventSpeaker { SpeakerId = speakerId });
            }

            if (!model.ImageFile.IsOkay())
            {
                ModelState.AddModelError(nameof(EventPostVM.Image), "There is a problem in your file");
                return View(model);
            }

            model.Image = FileUtils.Create(FileConstants.ImagePathEvent, model.ImageFile);


            Event eventt = new Event
            {
                Title = model.Title,
                Description = model.Description,
                Location = model.Location,
                Date = model.Date,
                HourEnd = model.HourEnd,
                HourStart = model.HourStart,
                Image = FileUtils.Create(FileConstants.ImagePathEvent, model.ImageFile),
                EventSpeakers = speakers
            };

            await _context.Events.AddAsync(eventt);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            Event events = await _context.Events.FindAsync(id);

            EventVM model = new EventVM
            {
                Event = events,
                Speakers = await _context.Speakers.Include(c => c.EventSpeakers).
                Where(c => c.EventSpeakers.Select(c => c.EventId).Contains(id)).ToListAsync(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteEvent(int id)
        {
            var eventt = await _context.Events.Include(f => f.EventSpeakers).ThenInclude(fc => fc.Speaker).FirstOrDefaultAsync(f => f.Id == id);
            if (eventt == null) return NotFound();

            
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathEvent, eventt.Image));
            _context.Remove(eventt);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
