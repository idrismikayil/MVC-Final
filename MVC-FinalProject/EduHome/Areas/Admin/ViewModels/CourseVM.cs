using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.Areas.Admin.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public List<Category> Categories { get; set; }
        public List<int> CategoryIds { get; set; }
        public Feature Feature { get; set; }
    }
}
