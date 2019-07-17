using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eatery.DAL;
using Eatery.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Eatery.Extension;


namespace Eatery.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly EatDb db;
        private readonly IHostingEnvironment env;
        public SliderController(EatDb eatDb, IHostingEnvironment _env)
        {
            db = eatDb;
            env = _env;

        }
        public IActionResult Index()
        {
            VModel vm = new VModel
            {
                Sliders = db.Sliders,
                StaticSlider = db.StaticSliders
            };
            return View(vm);
        }
        public IActionResult Screate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Screate(StaticSlider sl)
        {
            if (sl.IPhoto==null)
            {
                ModelState.AddModelError("IPhoto", "Image should be selected");
                return View(sl);
            }
            if (!sl.IPhoto.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("IPhoto", "file is not Image ");
                return View(sl);
            }
            if (sl.IPhoto.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("IPhoto", "Photo size is biggest");
                return View(sl);
            }
            //save
            //Yaratdi 0b
            
            string path = @"C:\Users\Ulvi\source\repos\Eatery\Eatery\wwwroot\img";
            string filename = (Guid.NewGuid().ToString()+ sl.IPhoto.FileName);
            string resultPath = Path.Combine(path, filename);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                

                await sl.IPhoto.CopyToAsync(fileStream);
            }
            sl.Image = filename;

             db.StaticSliders.Add(sl);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Dcreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Dcreate(Slider slider)
        {
            
            if (slider.Image == null)
            {
                ModelState.AddModelError("IPhoto", "Image should be selected");
                return View(slider);
            }
            if (!slider.Image.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("IPhoto", "file is not Image ");
                return View(slider);
            }
            if (slider.Image.Length / 1024 / 1024 > 2)
            {
                ModelState.AddModelError("IPhoto", "Photo size is biggest");
                return View(slider);
            }
           
            slider.SliderImage = await slider.Image.Save(env,"img");
            db.Sliders.Add(slider);
            await db.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? Id)
        {
            if (Id == null|| db.Sliders.FirstOrDefault(x => x.Id == Id)==null)
            {
                return Content("IMage not found");
            }
            return View(db.Sliders.FirstOrDefault(x=>x.Id==Id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? Id)
        {

            Slider slider = db.Sliders.FirstOrDefault(x => x.Id == Id);
            if (slider == null)
            {
                return Content("Slider yoxdur");
            }
            if (!System.IO.File.Exists(Path.Combine(env.WebRootPath, "img", slider.SliderImage)))
            {
                return Content(Path.Combine(env.WebRootPath, "img", slider.SliderImage) +"PAth Tapilmadi");
            }
                System.IO.File.Delete(Path.Combine(env.WebRootPath, "img", slider.SliderImage));

            db.Sliders.Remove(slider);
           await db.SaveChangesAsync();

            return Json("Slider is deleted");
        }
        public IActionResult Edit(int? Id)
        {

            if (Id == null)
            {
                return Content("Please enter Slider Id");
            }
            Slider slider= db.Sliders.FirstOrDefault(x => x.Id == Id);
            if (slider == null)
            {
                return Content("Slider is not Found!");
            }
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(int? Id,Slider slider)
        {
            Slider FinedSlider = await db.Sliders.FindAsync(slider.Id);
            if (slider.Image==null)
            {
              if (ModelState.IsValid)
                {
                    
                    
                    FinedSlider.Heading = slider.Heading;
                    FinedSlider.Content = slider.Content;
                    FinedSlider.SliderImage = slider.SliderImage;
                    
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));


                }
                else
                {
                    return View(slider);
                }
            }
            if(slider.Image.IsImage()) 
            
            {
                FinedSlider.SliderImage= await slider.Image.Save(env, "img");
                System.IO.File.Delete(env.WebRootPath + "img" + slider.SliderImage);
                FinedSlider.Content = slider.Content;
                FinedSlider.Heading = slider.Heading;
                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            
            return View(slider);
            
            
        }
    }
}