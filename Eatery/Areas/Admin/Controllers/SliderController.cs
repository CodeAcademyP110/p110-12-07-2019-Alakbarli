using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eatery.DAL;
using Eatery.Models;

namespace Eatery.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly EatDb db;
        public SliderController(EatDb eatDb)
        {
            db = eatDb;
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
    }
}