using Eatery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eatery.DAL
{
    public class EatDb:DbContext
    {
        public EatDb(DbContextOptions<EatDb>options):base(options)
        {
                
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<EatingType> EatingTypes { get; set; }
        public DbSet<SpecialDishes> SpecialDishes { get; set; }
        public DbSet<OurMenu> OurMenus { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<StaticSlider> StaticSliders { get; set; }
        public DbSet<HistoryPics> HistoryPics { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
    
}
