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

    public class SkillController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SkillController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Skill> skills = await _context.Skills.ToListAsync();
            return View(skills);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            if (skill == null) return NotFound();
            return View(skill);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill s)
        {
            //if (!ModelState.IsValid) return View();

            await _context.Skills.AddAsync(s);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Skill s = await _context.Skills.FindAsync(id);
            if (s == null) return NotFound();
            return View(s);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Skill s)
        {
            if (!ModelState.IsValid) return View();
            if (s.Id != id) return BadRequest();

            bool isExist = await _context.Skills.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Skills.Update(s);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            Skill s = await _context.Skills.FindAsync(id);
            if (s == null) return NotFound();
            return View(s);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteSkill(int id)
        {
            var s = await _context.Skills.FindAsync(id);
            if (s == null) return NotFound();
            _context.Skills.Remove(s);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
