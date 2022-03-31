using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class CourseDetailVM
    {
        public Course Course { get; set; }
        public Feature Feature { get; set; }
        public List<Category> Categories { get; set; }

    }
}
