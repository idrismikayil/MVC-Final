using EduHome.Constants;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class NoticeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public NoticeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var notice = await _context.Notices.ToListAsync();
            return View(notice);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var notice = await _context.Notices.FindAsync(id);
            if (notice == null) return NotFound();

            return View(notice);
        }

        public async Task<IActionResult> Update(int id)
        {
            var notice = await _context.Notices.FindAsync(id);
            if (notice == null) return NotFound();
            return View(notice);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, NoticeBoard notice)
        {
            if (!ModelState.IsValid) return View();
            if (notice.Id != id) return BadRequest();

            bool isExist = await _context.Notices.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Notices.Update(notice);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var notice = await _context.Notices.FindAsync(id);
            if (notice == null) return NotFound();
            return View(notice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteNotice(int id)
        {
            var not = await _context.Notices.FindAsync(id);
            if (not == null) return NotFound();
            _context.Notices.Remove(not);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NoticeBoard notice)
        {
            if (!ModelState.IsValid) return View();

            await _context.Notices.AddAsync(notice);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }


}

