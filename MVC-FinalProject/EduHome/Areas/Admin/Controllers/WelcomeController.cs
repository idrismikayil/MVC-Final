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

    public class WelcomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WelcomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<WelcomeMessage> w = await _context.WelcomeMessages.ToListAsync();
            return View(w);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var w = await _context.WelcomeMessages.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WelcomeMessage w)
        {
            //if (!ModelState.IsValid) return View();

            if (!w.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (w.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            w.Image = FileUtils.Create(FileConstants.ImagePathAbout, w.ImageFile);


            await _context.WelcomeMessages.AddAsync(w);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var w = await _context.WelcomeMessages.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, WelcomeMessage w)
        {
            //if (!ModelState.IsValid) return View();
            if (w.Id != id) return BadRequest();

            if (!w.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (w.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            w.Image = FileUtils.Create(FileConstants.ImagePathAbout, w.ImageFile);


            bool isExist = await _context.WelcomeMessages.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.WelcomeMessages.Update(w);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var w = await _context.WelcomeMessages.FindAsync(id);
            if (w == null) return NotFound();
            return View(w);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteWelcome(int id)
        {
            var w = await _context.WelcomeMessages.FindAsync(id);
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathAbout, w.Image));
            _context.WelcomeMessages.Remove(w);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

