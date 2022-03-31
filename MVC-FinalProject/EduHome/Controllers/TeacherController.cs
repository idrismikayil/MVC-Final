using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {

            var teachers = await _context.Teachers.Include(t=> t.TeacherContact).ToListAsync();
            return View(teachers);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Teacher teacher = await _context.Teachers.Include(x=>x.TeacherSkills).ThenInclude(s=>s.Skill).FirstOrDefaultAsync(c => c.Id == id);
            //var skills = await _context.Skills.Include(s=> s.)

            TeacherDetailVM vm = new TeacherDetailVM()
            {
                Teacher = teacher,
                TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync(f => f.TeacherId == id),
                //Skills = await _context.Skills.Where(s => s.TeacherId == id).ToListAsync(),
                


                //List < Course > courses = await _context.Courses.Include(c => c.CourseCategories).
                //Where(c => c.CourseCategories.Select(c => c.CategoryId).Contains(id)).ToListAsync(),


                //Skills = await _context.Skills.Include(s => s.TeacherSkill)

            };

            return View(vm);
        }

           
    }
}
