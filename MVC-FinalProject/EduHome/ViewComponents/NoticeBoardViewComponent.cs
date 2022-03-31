using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class NoticeBoardViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeBoardViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var board = await _context.Notices.OrderByDescending(n => n.Id).ToListAsync();
            return View(board);
        }
    }
}
