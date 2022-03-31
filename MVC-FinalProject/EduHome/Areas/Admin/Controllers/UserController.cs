﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EduHome.Areas.Admin.ViewModels;
using EduHome.Constants;
using EduHome.DAL;
using EduHome.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin + ", " + RoleConstants.Moderator)]
    public class UserController : Controller
    {
        private AppDbContext _dbContext;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;


        public UserController(AppDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _dbContext.Users.ToListAsync();
            List<UserVM> userList = new List<UserVM>();

            foreach (var user in users)
            {
                userList.Add(new UserVM
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.Fullname,
                    Roles = string.Join(", ", await _userManager.GetRolesAsync(user)),
                    isActive = user.isActive
                });
            }

            return View(userList);
        }

        public async Task<IActionResult> GetRoles(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            var roles = await _userManager.GetRolesAsync(user);

            ViewBag.Name = user.Fullname;
            ViewBag.UserId = user.Id;
            return View(roles);
        }

        public async Task<IActionResult> RemoveRole(string id, string roleName)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            await _userManager.RemoveFromRoleAsync(user, roleName);

            return RedirectToAction(nameof(GetRoles), new { user.Id });
        }

        public async Task<IActionResult> AddRole(string id)
        {
            var roles = await _dbContext.Roles.Select(r => r.Name).ToListAsync();

            AddRoleVM model = new AddRoleVM
            {
                UserId = id,
                Roles = roles
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(string id, AddRoleVM model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            await _userManager.AddToRoleAsync(user, model.RoleName);

            return RedirectToAction(nameof(GetRoles), new { id });

        }

        public async Task<IActionResult> ToggleBlock(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.isActive = !user.isActive;

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Block(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.isActive = false;

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UnBlock(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.isActive = true;

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
