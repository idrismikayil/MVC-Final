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
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class SpeakerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SpeakerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Speaker> s = await _context.Speakers.ToListAsync();
            return View(s);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var s = await _context.Speakers.FindAsync(id);
            if (s == null) return NotFound();
            return View(s);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speaker speaker)
        {
            //if (!ModelState.IsValid) return View();

            if (!speaker.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Speaker.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (speaker.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Speaker.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            speaker.Image = FileUtils.Create(FileConstants.ImagePathEvent, speaker.ImageFile);


            await _context.Speakers.AddAsync(speaker);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Speaker s = await _context.Speakers.FindAsync(id);
            if (s == null) return NotFound();
            return View(s);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Speaker s)
        {
            //if (!ModelState.IsValid) return View();
            if (s.Id != id) return BadRequest();

            if (!s.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Speaker.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (s.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Speaker.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            s.Image = FileUtils.Create(FileConstants.ImagePathEvent, s.ImageFile);


            bool isExist = await _context.Speakers.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Speakers.Update(s);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            Speaker s = await _context.Speakers.FindAsync(id);
            if (s == null) return NotFound();
            return View(s);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSpeaker(int id)
        {
            Speaker s = await _context.Speakers.FindAsync(id);
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathEvent, s.Image));
            _context.Speakers.Remove(s);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
