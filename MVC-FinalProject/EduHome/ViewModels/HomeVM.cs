using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Information> Informations { get; set; }
        public List<NoticeBoard> Notices { get; set; }
        public WhyUs WhyUs { get; set; }
        public Testimonial Testimonials { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public Layout Layout { get; set; }
        public List<Blog> Blogs { get; set; }


    }
}
