using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            List<Course> courses = await _context.Courses.Include(c=> c.CourseCategories).
                Where(c=> c.CourseCategories.Select(c=> c.CategoryId).Contains(id)).ToListAsync();

            if (courses == null) return NotFound();

            return View(courses);
        }
    }
}
