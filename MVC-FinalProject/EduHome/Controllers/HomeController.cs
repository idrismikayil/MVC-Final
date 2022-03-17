using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.OrderBy(s => s.Order).ToListAsync(),
                Informations = await _context.Informations.ToListAsync(),
                Notices = await _context.Notices.OrderByDescending(n => n.Date).ToListAsync(),
                WhyUs = await _context.WhyUs.FirstOrDefaultAsync(),
                Testimonials = await _context.Testimonials.FirstOrDefaultAsync(),
                Courses = await _context.Courses.Take(3).ToListAsync(),
            };
            return View(model);
        }
    }
}
