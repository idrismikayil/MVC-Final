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

    public class LayoutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public LayoutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Layout> layouts = await _context.Layout.ToListAsync();
            return View(layouts);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            if (layout == null) return NotFound();
            return View(layout);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Layout layout)
        {
            //if (!ModelState.IsValid) return View();

            if (!layout.NavImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.NavImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File size cannot be greater than 1 mb");
                return View();
            }
            if (!layout.FooterImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.FooterImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File size cannot be greater than 1 mb");
                return View();
            }


            layout.NavLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.NavImageFile);
            layout.FooterLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.FooterImageFile);


            await _context.Layout.AddAsync(layout);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            if (layout == null) return NotFound();
            return View(layout);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Layout layout)
        {
            if (!ModelState.IsValid) return View();
            if (layout.Id != id) return BadRequest();

            if (!layout.NavImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.NavImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.NavImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!layout.FooterImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (layout.FooterImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Layout.FooterImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            layout.NavLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.NavImageFile);
            layout.FooterLogo = FileUtils.Create(FileConstants.ImagePathLogo, layout.FooterImageFile);


            bool isExist = await _context.Layout.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Layout.Update(layout);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            if (layout == null) return NotFound();
            return View(layout);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteLayout(int id)
        {
            Layout layout = await _context.Layout.FindAsync(id);
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathLogo, layout.NavLogo));
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathLogo, layout.FooterLogo));
            _context.Layout.Remove(layout);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
