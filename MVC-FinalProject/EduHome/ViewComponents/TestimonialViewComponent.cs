using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public TestimonialViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonials = await _context.Testimonials.ToListAsync();

            return View(testimonials);
        }
    }
}
