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

    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ContactController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Contact> i = await _context.Contact.ToListAsync();
            return View(i);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var i = await _context.Contact.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Contact i)
        //{
        //    if (!ModelState.IsValid) return View();

        //    await _context.Contact.AddAsync(i);
        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact c)
        {

            if (!c.ImageFile1.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile1), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile1.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile1), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!c.ImageFile2.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile2), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile2.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile2), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!c.ImageFile3.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile3), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile3.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile3), "File size cannot be greater than 1 mb");
                return View();
            }

            c.IconOne = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile1);
            c.IconTwo = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile2);
            c.IconThree = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile3);

           

            await _context.Contact.AddAsync(c);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var i = await _context.Contact.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Contact c)
        {
            //if (!ModelState.IsValid) return View();
            if (c.Id != id) return BadRequest();

            if (!c.ImageFile1.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile1), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile1.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile1), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!c.ImageFile2.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile2), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile2.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile2), "File size cannot be greater than 1 mb");
                return View();
            }

            if (!c.ImageFile3.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile3), "File type is unsupported, please select image");
                return View();
            }
            if (c.ImageFile3.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Contact.ImageFile3), "File size cannot be greater than 1 mb");
                return View();
            }

            c.IconOne = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile1);
            c.IconTwo = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile2);
            c.IconThree = FileUtils.Create(FileConstants.ImagePathContact, c.ImageFile3);

            bool isExist = await _context.Contact.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Contact.Update(c);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            var i = await _context.Contact.FindAsync(id);
            if (i == null) return NotFound();
            return View(i);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteContact(int id)
        {
            var i = await _context.Contact.FindAsync(id);
            if (i == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathContact, i.IconOne));
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathContact, i.IconTwo));
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathContact, i.IconThree));
            _context.Contact.Remove(i);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
