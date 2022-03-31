using EduHome.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = RoleConstants.Admin)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
