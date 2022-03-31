using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class ReplyViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ReplyViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
