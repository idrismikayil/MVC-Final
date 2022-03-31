using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public CategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var category = await _context.Categories.ToListAsync();
            return View(category);
        }
    }
}
