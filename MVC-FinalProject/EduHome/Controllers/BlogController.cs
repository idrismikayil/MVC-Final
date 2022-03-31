using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _context.Blogs/*.Take(9)*/.ToListAsync();
            return View(blogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync(c => c.Id == id);
            return View(blog);
        }
    }
}
