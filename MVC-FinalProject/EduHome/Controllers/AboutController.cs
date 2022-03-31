using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            AboutVM model = new AboutVM()
            {
                WelcomeMessage = await _context.WelcomeMessages.FirstOrDefaultAsync(),
                Teachers = await _context.Teachers.Include(t => t.TeacherContact).Take(4).ToListAsync()
            };
            return View(model);
        }
    }
}
