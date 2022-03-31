using EduHome.Constants;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]

    public class WhyUsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WhyUsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<WhyUs> i = await _context.WhyUs.ToListAsync();
            return View(i);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var i = await _context.WhyUs.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WhyUs i)
        {
            if (!ModelState.IsValid) return View();

            await _context.WhyUs.AddAsync(i);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var i = await _context.WhyUs.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, WhyUs i)
        {
            if (!ModelState.IsValid) return View();
            if (i.Id != id) return BadRequest();

            bool isExist = await _context.WhyUs.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.WhyUs.Update(i);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var i = await _context.WhyUs.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteWhyUs(int id)
        {
            var i = await _context.WhyUs.FindAsync(id);
            if (i == null) return NotFound();
            _context.WhyUs.Remove(i);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}