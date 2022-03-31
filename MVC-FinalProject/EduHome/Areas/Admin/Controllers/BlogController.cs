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

    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            return View(blogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            //if (!ModelState.IsValid) return View();

            if (!blog.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (blog.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            blog.Image = FileUtils.Create(FileConstants.ImagePathBlog, blog.ImageFile);


            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Blog blog)
        {
            if (!ModelState.IsValid) return View();
            if (blog.Id != id) return BadRequest();

            if (!blog.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (blog.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Blog.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            blog.Image = FileUtils.Create(FileConstants.ImagePathBlog, blog.ImageFile);


            bool isExist = await _context.Blogs.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Blogs.Update(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathBlog, blog.Image));
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
