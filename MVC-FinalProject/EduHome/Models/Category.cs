using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public List<CourseCategory> CourseCategories { get; set; }

        //[NotMapped]
        //public int TotalCourse { get; set; }
    }
}
