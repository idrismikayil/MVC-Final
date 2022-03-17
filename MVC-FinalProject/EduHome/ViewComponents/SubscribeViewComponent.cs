using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public SubscribeViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var layout = await _context.Layout.FirstOrDefaultAsync();

            return View(layout);
        }
    }
}
