using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eatery.Models;
using Eatery.DAL;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace Eatery.Controllers
{
    public class HomeController : Controller
    {
        private readonly EatDb context;
        public HomeController(EatDb db)
        {
            context = db;
        }
        public IActionResult Index()
        {
            VModel vm = new VModel
            {
                Sliders = context.Sliders,
                EatingTypes = context.EatingTypes,
                SpecialDishes=context.SpecialDishes,
                OurMenus=context.OurMenus.Take(4),
                Testimonials=context.Testimonials,
                Blogs=context.Blogs
                
            };
            
            
            return View(vm);
        }
        public IActionResult Recipes()
        {
            VModel vm = new VModel
            {
                StaticSlider = context.StaticSliders,
                OurMenus=context.OurMenus,
                EatingTypes=context.EatingTypes
            };
            return View(vm);
        }
        public IActionResult Services(string Id)
        {
            VModel vm = new VModel
            {
                StaticSlider = context.StaticSliders,
                EatingTypes = context.EatingTypes.Where(et=>et.Heading==Id)

            };
            ViewBag.Id = Id;
            return View(vm);
        }
        public IActionResult About()
        {
            VModel vm = new VModel
            {
                StaticSlider = context.StaticSliders,
                History = context.Histories,
                HistoryPics=context.Histories.Include(x=>x.HistoryPics).FirstOrDefault().HistoryPics,
                Chefs=context.Chefs
                
               
            };
            return View(vm);
        }
        public IActionResult News()
        {
            VModel vm = new VModel
            {
                StaticSlider = context.StaticSliders,
                OurMenus = context.OurMenus

            };
            
            return View(vm);
        }
        public IActionResult Contact()
        {
            VModel vm = new VModel
            {
                StaticSlider = context.StaticSliders,
                Contacts = context.Contacts
            };
            return View(vm);
        }


       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
