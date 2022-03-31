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

    public class InformationController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public InformationController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Information> i = await _context.Informations.ToListAsync();
            return View(i);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var i = await _context.Informations.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Information i)
        {
            if (!ModelState.IsValid) return View();

            await _context.Informations.AddAsync(i);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var i = await _context.Informations.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Information i)
        {
            if (!ModelState.IsValid) return View();
            if (i.Id != id) return BadRequest();

            bool isExist = await _context.Informations.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Informations.Update(i);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            var i = await _context.Informations.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteInformation(int id)
        {
            var i = await _context.Informations.FindAsync(id);
            if (i == null) return NotFound();
            _context.Informations.Remove(i);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
