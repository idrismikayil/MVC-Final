using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public SubscribeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<JsonResult> addSubscriber(string email)
        {
            if (!String.IsNullOrEmpty(email))
            {
                return Json(400);
            }
            Subscriber subscribe = new Subscriber
            {
                Email = email
            };

            await _dbContext.Subscribers.AddAsync(subscribe);
            await _dbContext.SaveChangesAsync();

            return Json(200);
        }
    }
}
