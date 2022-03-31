using EduHome.DAL;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public LoginViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
