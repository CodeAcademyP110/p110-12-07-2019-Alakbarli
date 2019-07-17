using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eatery.Models
{
    public class VModel
    {
        public IEnumerable<Slider>Sliders{get;set;}
        public IEnumerable<EatingType> EatingTypes { get; set; }
        public IEnumerable<SpecialDishes> SpecialDishes { get; set; }
        public IEnumerable<OurMenu> OurMenus { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<StaticSlider> StaticSlider { get; set; }
        public IEnumerable<History> History { get; set; }
        public IEnumerable<HistoryPics> HistoryPics { get; set; }
        public IEnumerable<Chef> Chefs { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }

    }
}
