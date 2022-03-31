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

    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TestimonialController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Testimonial> t = await _context.Testimonials.ToListAsync();
            return View(t);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var t = await _context.Testimonials.FindAsync(id);
            if (t == null) return NotFound();
            return View(t);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial t)
        {
            //if (!ModelState.IsValid) return View();

            if (!t.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Testimonial.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (t.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Testimonial.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            t.MainImage = FileUtils.Create(FileConstants.ImagePathTestimonial, t.ImageFile);


            await _context.Testimonials.AddAsync(t);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var t = await _context.Testimonials.FindAsync(id);
            if (t == null) return NotFound();
            return View(t);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Testimonial t)
        {
            //if (!ModelState.IsValid) return View();
            if (t.Id != id) return BadRequest();

            if (!t.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Testimonial.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (t.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Testimonial.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            t.MainImage = FileUtils.Create(FileConstants.ImagePathTestimonial, t.ImageFile);


            bool isExist = await _context.Testimonials.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Testimonials.Update(t);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var t = await _context.Testimonials.FindAsync(id);
            if (t == null) return NotFound();
            return View(t);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var t = await _context.Testimonials.FindAsync(id);

            FileUtils.Delete(Path.Combine(FileConstants.ImagePathTestimonial, t.MainImage));
            _context.Testimonials.Remove(t);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
