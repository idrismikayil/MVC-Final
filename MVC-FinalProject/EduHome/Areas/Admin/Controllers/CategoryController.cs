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

    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> cat = await _context.Categories.ToListAsync();
            return View(cat);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Category category)
        {
            if (!ModelState.IsValid) return View();
            if (category.Id != id) return BadRequest();

            bool isExist = await _context.Categories.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteCategory(int id)
        {
            var cats = await _context.Categories.FindAsync(id);
            if (cats == null) return NotFound();
            _context.Categories.Remove(cats);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
