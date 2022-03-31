using EduHome.Areas.Admin.ViewModels;
using EduHome.Constants;
using EduHome.DAL;
using EduHome.Extensions;
using EduHome.FileUtilities;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]

    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (!slider.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (slider.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            slider.Image = FileUtils.Create(FileConstants.ImagePathSlider, slider.ImageFile);

            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Detail(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        public async Task<ActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]

        public async Task<ActionResult> DeleteSlider(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            FileUtils.Delete(Path.Combine(FileConstants.ImagePathSlider, slider.Image));
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult CreateMultiple()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateMultiple(CreateMultipleSliderVM model)
        {
            if (!ModelState.IsValid) return View();

            foreach (var image in model.Images)
            {
                byte order = 1;

                if (!image.IsOkay())
                {
                    ModelState.AddModelError(nameof(Slider.ImageFile), $"There is problem in your image named {image.FileName}");
                    return View();
                }

                Slider slider = new Slider
                {
                    TopTitle = model.Title,
                    Description = model.Desc,
                    Image = FileUtils.Create(FileConstants.ImagePathSlider, image),
                    Order = order++,
                };

                await _context.Sliders.AddAsync(slider);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index"); ;
        }

        public async Task<IActionResult> Update(int id)
        {
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Id != id) return BadRequest();

            if (!slider.ImageFile.IsSupported("image"))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File type is unsupported, please select image");
                return View();
            }
            if (slider.ImageFile.IsGreatergivenMb(1))
            {
                ModelState.AddModelError(nameof(Slider.ImageFile), "File size cannot be greater than 1 mb");
                return View();
            }

            //Slider slider2 = new Slider
            //{
            //    TopTitle = model.Title,
            //    Description = model.Desc,
            //    Image = FileUtils.Create(FileConstants.ImagePathSlider, image),
            //    Order = order++,
            //};

            slider.Image = FileUtils.Create(FileConstants.ImagePathSlider, slider.ImageFile);

            bool isExist = await _context.Sliders.AnyAsync(l => l.Id == id);
            if (!isExist) return NotFound();

            _context.Sliders.Update(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
