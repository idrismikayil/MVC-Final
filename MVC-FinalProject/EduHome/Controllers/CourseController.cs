using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var course = await _context.Courses.ToListAsync();
            return View(course);
        }


        public async Task<IActionResult> Detail(int id)
        {
            Course course = await _context.Courses.Include(c => c.Feature).FirstOrDefaultAsync(c => c.Id == id);

            CourseDetailVM model = new CourseDetailVM
            {
                Course = course,
                Feature = await _context.Features.FirstOrDefaultAsync(f => f.Course.Id == id),
            };

            return View(model);
        }

        public async Task<IActionResult> Search(string searchStr)
        {
            if (string.IsNullOrWhiteSpace(searchStr))
            {
                return PartialView("_SearchPartialView", new List<Course>());
            }

            var course = await _context.Courses.Where(f => f.MainTitle.ToUpper().Contains(searchStr.ToUpper())).ToListAsync();
            return PartialView("_SearchPartialView", course);
        }
    }
}
