using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Eatery.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string SliderImage { get; set; }
        [StringLength(300)]
        public string Heading { get; set; }
        [Required, StringLength(100)]
        public string Content { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
    public class EatingType
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Icon { get; set; }
      
        [Required, StringLength(50)]
        public string Heading { get; set; }
        [Required, StringLength(500)]
        public string Content { get; set; }
    }
    public class SpecialDishes
    {
        public int Id { get; set; }
        
        public decimal Price { get; set; }
        [Required, StringLength(100)]
        public string Heading { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
    }
    public class OurMenu
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        [StringLength(300)]
        public string Heading { get; set; }
        [Required, StringLength(300)]
        public string Content { get; set; }
        public decimal Price { get; set; }

    }
    public class Testimonial
    {
        public int Id { get; set; }
        [Required, StringLength(500)]
        public string Content { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [StringLength(350)]
        public string PersonName { get; set; }
        [Required, StringLength(50)]
        public string PersonPosition { get; set; }
       

    }
    public class Blog
    {
        public int Id { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [ StringLength(300)]
        public string Heading { get; set; }
        
        public DateTime Date  { get; set; }
        [Required, StringLength(400)]
        public string Content { get; set; }

    }
    public class StaticSlider
    {
        public int Id { get; set; }
        [StringLength(400)]
        public string Image { get; set; }
        [StringLength(300)]
        public string Heading { get; set; }
        [Required(ErrorMessage ="Doldur"), StringLength(50)]
        public string ActionName { get; set; }
        [NotMapped]
        public IFormFile IPhoto { get; set; }
    }
    public class HistoryPics
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int HistoryId { get; set; }
        public virtual History History { get; set; }
        
    }
    public class History
    {
        public int Id { get; set; }
        public string Content { get; set; }
        
        public virtual IEnumerable<HistoryPics> HistoryPics { get; set; }
        
    }
    public class Chef
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }
        [Required, StringLength(50)]
        public string Position { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
    }
    public class Contact
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string Phone { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
    }

   
        
}
