﻿using EduHome.Areas.Admin.ViewModels;
using EduHome.Constants;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.FileUtilities;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]

    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }

        public async Task<IActionResult> Detail(int id)
        {
            //var teachers = await _context.Teachers.Include(t=> t.TeacherContact).FirstOrDefaultAsync(t=>t.Id==id);
            var teacher = await _context.Teachers.Include(x => x.TeacherSkills).ThenInclude(s => s.Skill).FirstOrDefaultAsync(c => c.Id == id);


            TeacherDetailVM model = new TeacherDetailVM
            {
                Teacher = teacher,
                TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync(f => f.TeacherId == id),
                //Skills = await _context.Skills.Include(c => c.TeacherSkills).
                //Where(c => c.TeacherSkills.Select(c => c.TeacherId).Contains(id)).ToListAsync(),
                //TeacherSkills = await _context.Skills.Include(c=> c.TeacherSkills).Where(c => c.TeacherSkills.Select(c => c.Percentage).Contains(id)).ToListAsync(),
            };
            return View(model);
        }

        public async Task<IActionResult> Update(int id)
        {
            var teacher = await _context.Teachers.Include(t=> t.TeacherContact).Include(t=> t.TeacherSkills).ThenInclude(t=> t.Skill).FirstOrDefaultAsync(f => f.Id == id);
            if (teacher == null) return NotFound();

            TeacherPostVM model = new TeacherPostVM
            {
                SkillIds = teacher.TeacherSkills.Select(c => c.Id).ToList(),
                Fullname = teacher.Fullname,
                About = teacher.About,
                Faculty = teacher.Faculty,
                Experience = teacher.Experience,
                Degree = teacher.Degree,
                Position = teacher.Position,
                Hobbies = teacher.Hobbies,
                Image = teacher.Image,
                Skills = await _context.Skills.ToListAsync(),
                TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync(),
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, TeacherPostVM model)
        {
            var teacher = await _context.Teachers.Include(t => t.TeacherContact).Include(t => t.TeacherSkills).ThenInclude(t => t.Skill).FirstOrDefaultAsync(f => f.Id == id);
            if (teacher == null) return NotFound();

            model.Skills = await _context.Skills.ToListAsync();
            model.TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync();

            //if (!ModelState.IsValid) return View(model);

            List<TeacherSkill> skills = new List<TeacherSkill>();
            foreach (var skillId in model.SkillIds)
            {
                var skill = await _context.Skills.FindAsync(skillId);
                if (skill == null)
                {
                    ModelState.AddModelError(nameof(TeacherPostVM.SkillIds), "Choose a valid skill");
                    return View(model);
                }
                skills.Add(new TeacherSkill { SkillId = skillId });
            }

            //if (model.Image != null)
            //{
            //    if (!model.ImageFile.IsOkay())
            //    {
            //        ModelState.AddModelError(nameof(TeacherPostVM.Image), "There is a problem in your file");
            //        return View(model);
            //    }

            //    FileUtils.Delete(Path.Combine(FileConstants.ImagePathTeacher, teacher.Image));
            //}

            if (!model.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Teacher.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (model.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Teacher.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            model.Image = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile);

            teacher.Fullname = model.Fullname;
            teacher.About = model.About;
            teacher.Hobbies = model.Hobbies;
            teacher.Experience = model.Experience;
            teacher.Degree = model.Degree;
            teacher.Faculty = model.Faculty;
            teacher.Position = teacher.Position;
            teacher.TeacherContact = model.TeacherContact;
            teacher.Image = model.Image != null ? FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile) : teacher.Image;

            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create()
        {
            TeacherPostVM model = new TeacherPostVM
            {
                Skills = await _context.Skills.ToListAsync()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherPostVM model)
        {
            model.Skills = await _context.Skills.ToListAsync();

            //if (!ModelState.IsValid) return View(model);

            List<TeacherSkill> skills = new List<TeacherSkill>();
            foreach (var skillId in model.SkillIds)
            {
                var skill = await _context.Skills.FindAsync(skillId);
                if (skill == null)
                {
                    ModelState.AddModelError(nameof(TeacherPostVM.SkillIds), "Choose a valid skill");
                    return View(model);
                }
                skills.Add(new TeacherSkill { SkillId = skillId });
            };

            if (!model.ImageFile.IsOkay())
            {
                ModelState.AddModelError(nameof(TeacherPostVM.ImageFile), "There is a problem in your file");
                return View(model);
            };


            Teacher teacher = new Teacher
            {
                Fullname = model.Fullname,
                About = model.About,
                Hobbies = model.Hobbies,
                Experience = model.Experience,
                Degree = model.Degree,
                Faculty = model.Faculty,
                Position = model.Position,
                TeacherContact = model.TeacherContact,
                Image = FileUtils.Create(FileConstants.ImagePathTeacher, model.ImageFile),
                TeacherSkills = skills,

            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _context.Teachers.Include(x => x.TeacherSkills).ThenInclude(s => s.Skill).FirstOrDefaultAsync(c => c.Id == id);

            TeacherDetailVM model = new TeacherDetailVM
            {
                Teacher = teacher,
                TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync(f => f.TeacherId == id),
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.Include(x => x.TeacherSkills).ThenInclude(s => s.Skill).FirstOrDefaultAsync(c => c.Id == id);

            TeacherDetailVM model = new TeacherDetailVM
            {
                Teacher = teacher,
                TeacherContact = await _context.TeacherContact.FirstOrDefaultAsync(f => f.TeacherId == id),
            };
            if (teacher == null) return NotFound();

            
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathTeacher, teacher.Image));
            _context.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
