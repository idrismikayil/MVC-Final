using EduHome.Areas.Admin.ViewModels;
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
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
           
        }

        public async Task<IActionResult> Detail(int id)
        {
            var course = await _context.Courses.Include(c=> c.Feature).Include(f => f.CourseCategories)
                   .ThenInclude(fc => fc.Category).AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);

            if (course == null) return NotFound();

            return View(course);
        }

        public async Task<IActionResult> Update(int id)
        {
            var course = await _context.Courses.Include(t => t.Feature).Include(t => t.CourseCategories).ThenInclude(t => t.Category).FirstOrDefaultAsync(f => f.Id == id);
            if (course == null) return NotFound();

            List<Category> cts = new List<Category>();
            foreach (var item in course.CourseCategories)
            {
                cts.Add(item.Category);
            }

            CourseVM model = new CourseVM();

            model.Course = course;
            model.Categories = _context.Categories.ToList();
            model.CategoryIds = cts.Select(x => x.Id).ToList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CourseVM model)
        {
            var course = await _context.Courses.Include(t => t.Feature).Include(t => t.CourseCategories).ThenInclude(t => t.Category).FirstOrDefaultAsync(f => f.Id == id);
            if (course == null) return NotFound();

            model.Feature = await _context.Features.FirstOrDefaultAsync();

            List<Category> categories1 = new List<Category>();

            var oldCategoryIds = await _context.CourseCategories.Where(x => x.CourseId == model.Course.Id).Select(x => x.CategoryId).ToListAsync();

            foreach (var oldId in oldCategoryIds)
            {
                var oldCourseCat = await _context.CourseCategories.FirstOrDefaultAsync(x => x.CategoryId == oldId && x.CourseId == model.Course.Id);
                _context.CourseCategories.Remove(oldCourseCat);
            }

            foreach (var newId in model.CategoryIds)
            {
                CourseCategory crsCat = new CourseCategory() { CourseId = model.Course.Id, CategoryId = newId };
                await _context.CourseCategories.AddAsync(crsCat);
            }

            if (!model.Course.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Course.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (model.Course.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Course.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            model.Course.Image = FileUtils.Create(FileConstants.ImagePathCourse, model.Course.ImageFile);

            //course.MainTitle = model.MainTitle;
            //course.AboutDesc = model.AboutDesc;
            //course.MainDesc = model.MainDesc;
            //course.ApplyDesc = model.ApplyDesc;
            //course.CertificationDesc = model.CertificationDesc;
            //course.Feature = model.Feature;
            //course.Image = model.Image != null ? FileUtils.Create(FileConstants.ImagePathCourse, model.ImageFile) : course.Image;

            CourseVM vm = new CourseVM
            {
                Course = model.Course,
                Categories = await _context.Categories.Include(c => c.CourseCategories).ThenInclude(s => s.Category)
                .Where(c => c.CourseCategories.Select(c => c.CourseId).Contains(id)).ToListAsync(),
                Feature = model.Feature,
            };

            bool isExist = await _context.Courses.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Courses.Update(model.Course);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create()
        {
            CoursePostVM model = new CoursePostVM
            {
                Categories = await _context.Categories.ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CoursePostVM model)
        {
            model.Categories = await _context.Categories.ToListAsync();
            //if (!ModelState.IsValid) return View(model);

            List<CourseCategory> categories = new List<CourseCategory>();
            foreach (var categoryId in model.CategoryIds)
            {
                var category = await _context.Speakers.FindAsync(categoryId);
                //if (category == null)
                //{
                //    ModelState.AddModelError(nameof(CoursePostVM.CategoryIds), "Choose a valid category");
                //    return View(model);
                //}
                categories.Add(new CourseCategory { CategoryId = categoryId });
            }

            if (!model.ImageFile.IsOkay())
            {
                ModelState.AddModelError(nameof(CoursePostVM.Image), "There is a problem in your file");
                return View(model);
            }

            model.Image = FileUtils.Create(FileConstants.ImagePathCourse, model.ImageFile);

            Course course = new Course
            {
                MainTitle = model.MainTitle,
                MainDesc = model.MainDesc,
                AboutDesc = model.AboutDesc,
                ApplyDesc = model.ApplyDesc,
                CertificationDesc = model.CertificationDesc,
                Feature = model.Feature,
                Image = FileUtils.Create(FileConstants.ImagePathCourse, model.ImageFile),
                CourseCategories = categories
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var course = await _context.Courses.Include(c => c.Feature).Include(f => f.CourseCategories)
                  .ThenInclude(fc => fc.Category).AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);

            if (course == null) return NotFound();

            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.Include(c => c.Feature).Include(f => f.CourseCategories)
                 .ThenInclude(fc => fc.Category).AsNoTracking().FirstOrDefaultAsync(f => f.Id == id);

            if (course == null) return NotFound();

            FileUtils.Delete(Path.Combine(FileConstants.ImagePathCourse, course.Image));
            _context.Remove(course);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
